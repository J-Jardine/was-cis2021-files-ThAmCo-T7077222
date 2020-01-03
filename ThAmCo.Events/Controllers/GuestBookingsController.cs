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
    public class GuestBookingsController : Controller
    {
        private readonly EventsDbContext _context;

        public GuestBookingsController(EventsDbContext context)
        {
            _context = context;
        }

        // GET: GuestBookings
        public async Task<IActionResult> Index([FromQuery]int? EventId)
        {
            var eventsDbContext = _context.Guests.Include(g => g.Customer).Include(g => g.Event).Where(g => g.EventId == EventId);
            var currentEvent = _context.Events.Find(EventId);
            if (currentEvent == null)
            {
                return BadRequest();
            }
            ViewData["Title"] = currentEvent.Title;
            return View(await eventsDbContext.ToListAsync());
        }

        // GET: GuestBookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guestBooking = await _context.Guests
                .Include(g => g.Customer)
                .Include(g => g.Event)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (guestBooking == null)
            {
                return NotFound();
            }

            return View(guestBooking);
        }

        // GET: GuestBookings/Create
        public IActionResult Create([FromQuery] int? EventId)
        {
            if (EventId == null)
            {
                return BadRequest();
            }

            //Removes customers already booked onto the event
            var customers = _context.Customers.ToList();
            var bookedGuests = _context.Guests.Where(g => g.EventId == EventId).ToList();
            customers.RemoveAll(r => bookedGuests.Any(g => g.CustomerId == r.Id));
            
            //var events = _context.Events.ToList();
            //var currentEvents = _context.Events.Where(g => g.Id == EventId).ToList();
            //events.RemoveAll(r => currentEvents.Any(g => EventId != r.Id));

            var currentEvent = _context.Events.Find(EventId);
            if (currentEvent == null)
            {
                return BadRequest();
            }

            if (customers.Count == 0)
            {
                ModelState.AddModelError(string.Empty, "No more customers to book onto this event.");
            }

            ViewData["CustomerId"] = new SelectList(customers, "Id", "Email");
            //ViewData["EventId"] = new SelectList(events, "Id", "Title");
            ViewData["Title"] = currentEvent.Title;
            return View();
        }

        // POST: GuestBookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,EventId,Attended")] GuestBooking guestBooking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guestBooking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Email", guestBooking.CustomerId);
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Title", guestBooking.EventId);
            return View(guestBooking);
        }

        // GET: GuestBookings/Edit/5
        public async Task<IActionResult> Edit(int? id, int? eventId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guestBooking = await _context.Guests.FindAsync(id, eventId);
            if (guestBooking == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Email", guestBooking.CustomerId);
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Title", guestBooking.EventId);
            return View(guestBooking);
        }

        // POST: GuestBookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,EventId,Attended")] GuestBooking guestBooking)
        {
            if (id != guestBooking.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guestBooking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuestBookingExists(guestBooking.CustomerId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Email", guestBooking.CustomerId);
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Title", guestBooking.EventId);
            return View(guestBooking);
        }

        // GET: GuestBookings/Delete/5
        public async Task<IActionResult> Delete(int? id, int? eventId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guestBooking = await _context.Guests
                .Include(g => g.Customer)
                .Include(g => g.Event)
                .Where(g => g.CustomerId == id)
                .Where(g => g. EventId == eventId)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (guestBooking == null)
            {
                return NotFound();
            }

            return View(guestBooking);
        }

        // POST: GuestBookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id, int eventId)
        {
            var guestBooking = await _context.Guests.FindAsync(id, eventId);
            _context.Guests.Remove(guestBooking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        private bool GuestBookingExists(int id)
        {
            return _context.Guests.Any(e => e.CustomerId == id);
        }
    }
}
