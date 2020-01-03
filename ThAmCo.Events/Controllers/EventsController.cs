using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

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
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
