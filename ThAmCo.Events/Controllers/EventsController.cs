using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;
using ThAmCo.Events.Models;
using ThAmCo.Venues.Models;

namespace ThAmCo.Events.Controllers
{
    public class EventsController : Controller
    {
        private readonly EventsDbContext _context;

        public EventsController(EventsDbContext context)
        {
            _context = context;
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            var eventDb = _context.Events;
            var events = await eventDb.ToListAsync();

            List<Models.EventIndexViewModel> eventIndex = new List<Models.EventIndexViewModel>();
            foreach (Event e in events) 
            {
                Models.EventIndexViewModel eventViewModel = new Models.EventIndexViewModel();
                eventViewModel.Date = e.Date;
                eventViewModel.Duration = e.Duration;
                eventViewModel.Id = e.Id;
                eventViewModel.Title = e.Title;
                eventViewModel.GuestCount = _context.Guests.Where(g => g.EventId == e.Id).Count();
                eventViewModel.StaffCount = _context.Staffing.Where(g => g.EventId == e.Id).Count();
                eventIndex.Add(eventViewModel);
            }

            return View(eventIndex);
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .Select(m => new Models.EventDetailsViewModel
                {
                    Id = m.Id,
                    Title = m.Title,
                    Date = m.Date,
                    Duration = m.Duration,
                    TypeId = m.TypeId,
                    GuestCount = _context.Guests.Where(g => g.EventId == m.Id).Count(),
                    StaffCount = _context.Staffing.Where(g => g.EventId == m.Id).Count(),
                    Venue = m.Venue,
                    VenueCost = m.VenueCost,
                    Description = m.Description,
                    WhenMade = m.WhenMade,
                    Capacity = m.Capacity,

                    Guests = _context.Guests.Where(g => g.EventId == m.Id).Select(g => new Models.GuestViewModel
                    {
                        Id = g.Customer.Id,
                        FullName = g.Customer.FirstName + " " + g.Customer.Surname,
                        Email = g.Customer.Email,
                        Attended = g.Attended
                    }),
                    Staff = _context.Staffing.Where(g => g.EventId == m.Id).Select(g => new Models.StaffViewModel
                    {
                        Id = g.Staff.Id,
                        FullName = g.Staff.FirstName + " " + g.Staff.Surname,
                        FirstAider = g.Staff.FirstAider
                    })
                }).FirstOrDefaultAsync(m => m.Id == id);

            var guestList = _context.Guests.Where(g => g.EventId == @event.Id);
            var staffList = _context.Staffing.Where(g => g.EventId == @event.Id);
            int guestCount = guestList.Count();
            int staffCount = staffList.Count();
            if (staffCount > 0 && staffCount >= (guestCount / 10))
            {
                @event.EnoughStaff = "Enough staff assigned";
                @event.EnoughStaffBool = false;
            }
            else
            {
                @event.EnoughStaff = "Not enough staff assigned";
                @event.EnoughStaffBool = true;
            }

            if (staffList.Where(f => f.Staff.FirstAider).Count() > 0)
            {
                @event.FirstAider = "First aider assigned";
                @event.FirstAiderBool = false;
            }
            else
            {
                @event.FirstAider = "No first aider asigned";
                @event.FirstAiderBool = true;
            }

            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Date,Duration,TypeId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Duration")] Models.EditEventViewModel @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Setting the variables to the information that is in the database
                    var editEvent = await _context.Events.FindAsync(id);
                    editEvent.Title = @event.Title;
                    editEvent.Duration = @event.Duration;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            @event.isDeleted = false;

            _context.Guests.RemoveRange(_context.Guests.Where(g => g.EventId == id));
            _context.Staffing.RemoveRange(_context.Staffing.Where(g => g.EventId == id));

            HttpClient client = new HttpClient();
            client.BaseAddress = new System.Uri("http://localhost:23652");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");

            HttpResponseMessage delete = await client.DeleteAsync("api/reservations/" + @event.Reference);

            @event.Reference = null;

            _context.Update(@event);

            //_context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }

        public async Task<IActionResult> AvailableVenues(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            HttpClient client = new HttpClient();
            client.BaseAddress = new System.Uri("http://localhost:23652");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");

            var curEvent = await _context.Events.FindAsync(id);

            String eventType = curEvent.TypeId;
            DateTime beginDate = curEvent.Date;
            DateTime endDate = curEvent.Date.Add(curEvent.Duration.Value);

            var availableVenues = new List<AvailableVenues>().AsEnumerable();

            HttpResponseMessage response = await client.GetAsync("api/Availability?eventType=" + eventType
                + "&beginDate=" + beginDate.ToString("yyyy/MM/dd")
                + "&endDate=" + endDate.ToString("yyyy/MM/dd"));

            //handle empty venues

            if (response.IsSuccessStatusCode)
            {
                availableVenues = await response.Content.ReadAsAsync<IEnumerable<AvailableVenues>>();

                if (availableVenues.Count() == 0)
                {
                    Debug.WriteLine("No available venues");
                }
            }
            else
            {
                Debug.WriteLine("Recieved a bad response from service");
            }


            var staff = await _context.Staff.Select(s => new StaffList
            {
                Id = s.Id,
                FullName = s.FirstName + " " + s.Surname,
                StaffCode = s.StaffCode
            }).ToListAsync();

            ViewData["VenueList"] = new SelectList(availableVenues, "Code", "Name");
            ViewData["StaffList"] = new SelectList(staff, "StaffCode", "FullName");
            ViewData["EventTitle"] = curEvent.Title;
            ViewData["EventId"] = curEvent.Id;

            return View(availableVenues);

        }

        public async Task<IActionResult> ReserveVenue(int? eventId, string venueCode, string staffId)
        {
            if (eventId == null || venueCode == null || staffId == null)
            {
                return BadRequest();
            }

            var @event = await _context.Events.FindAsync(eventId);
            HttpClient client = new HttpClient();
            client.BaseAddress = new System.Uri("http://localhost:23652");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");

            HttpResponseMessage getAvailability = await client.GetAsync("api/Availability?eventType=" + @event.TypeId
                + "&beginDate=" + @event.Date.ToString("yyyy/MM/dd")
                + "&endDate=" + @event.Date.ToString("yyyy/MM/dd"));

            var availability = await getAvailability.Content.ReadAsAsync<IEnumerable<AvailableVenues>>();

            decimal venueCost = (decimal)availability.FirstOrDefault(r => r.Code == venueCode).CostPerHour;
            @event.VenueCost = venueCost * @event.Duration.Value.Hours;

            @event.Venue = availability.FirstOrDefault(r => r.Code == venueCode).Name;

            _context.Update(@event);
            await _context.SaveChangesAsync();

            DateTime eventDate = @event.Date;

            ReservationPostDto reservation = new ReservationPostDto();
            reservation.EventDate = eventDate;
            reservation.StaffId = staffId;
            reservation.VenueCode = venueCode;

            @event.Description = availability.FirstOrDefault(r => r.Code == venueCode).Description;
            @event.Capacity = availability.FirstOrDefault(r => r.Code == venueCode).Capacity;
            @event.WhenMade = reservation.EventDate;

            if (@event.Reference != null)
            {
                HttpResponseMessage delete = await client.DeleteAsync("api/reservations/" + @event.Reference);
            }

            @event.Reference = reservation.VenueCode + reservation.EventDate.ToString("yyyyMMdd");

            _context.Update(@event);
            await _context.SaveChangesAsync();

            HttpResponseMessage post = await client.PostAsJsonAsync("api/reservations", reservation);

            if (post.IsSuccessStatusCode)
            {

                HttpResponseMessage getReservation = await client.GetAsync("api/reservations/" + @event.Reference);
                var x = await getReservation.Content.ReadAsAsync<ReservationViewModel>();
                return View("Reservation", x);
            }
             else
            {
                return RedirectToAction(nameof(Details), eventId);
            }

        }
    }
}
