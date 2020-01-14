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
    /// <summary>
    /// Controller for Staff
    /// </summary>
    public class StaffsController : Controller
    {
        /// <summary>
        /// Allowing EventsDbContext to be used
        /// </summary>
        private readonly EventsDbContext _context;

        /// <summary>
        /// Initiaised the staff controller
        /// </summary>
        /// <param name="context"></param>
        public StaffsController(EventsDbContext context)
        {
            _context = context;
        }

        // GET: Staffs
        /// <summary>
        /// Pulls the index of all staff members
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var staffDb = _context.Staff;
            var staffs = await staffDb.ToListAsync();

            List<Models.StaffIndexViewModel> staffIndex = new List<Models.StaffIndexViewModel>();
            foreach (Staff e in staffs)
            {
                Models.StaffIndexViewModel staffViewModel = new Models.StaffIndexViewModel();
                staffViewModel.Id = e.Id;
                staffViewModel.FullName = e.FirstName + " " + e.Surname;
                staffViewModel.FirstAider = e.FirstAider;
                staffViewModel.Email = e.Email;
                staffIndex.Add(staffViewModel);
            }
            return View(staffIndex);
        }

        // GET: Staffs/Details/5
        /// <summary>
        /// Pulls the detials view of a staff member based of the 
        /// id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.Select(m => new Models.StaffDetailsViewModel
            {
                Id = m.Id,
                FullName = m.FirstName + " " + m.Surname,
                Email = m.Email,
                FirstAider = m.FirstAider,
                Events = _context.Staffing.Where(s => s.StaffId == m.Id).Select(e => new Event
                {
                    Id = e.EventId,
                    Date = e.Event.Date,
                    Title = e.Event.Title
                }).Where(w => w.Date >= DateTime.Now)
            }).FirstOrDefaultAsync(m => m.Id == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // GET: Staffs/Create
        /// <summary>
        /// Gets the create view for creating a new staff member
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        // POST: Staffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Adds the newly created staff member to the database
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Surname,FirstName,FirstAider")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staff);
        }

        // GET: Staffs/Edit/5
        /// <summary>
        /// Gets the edit view for a staff member from the
        /// selected id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }
            return View(staff);
        }

        // POST: Staffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Puts the edited staff member details into the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="staff"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Surname,FirstName,FirstAider, Email")] Staff staff)
        {
            if (id != staff.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffExists(staff.Id))
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
            return View(staff);
        }

        // GET: Staffs/Delete/5
        /// <summary>
        /// Gets the delete view for a staff member from the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff
                .FirstOrDefaultAsync(m => m.Id == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // POST: Staffs/Delete/5
        /// <summary>
        /// Deletes the staff member from the database from the 
        /// selected id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staff = await _context.Staff.FindAsync(id);
            _context.Staff.Remove(staff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Checking to see if the staff member exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool StaffExists(int id)
        {
            return _context.Staff.Any(e => e.Id == id);
        }

        /// <summary>
        /// Ajax method for updating the staff first aided boolean 
        /// based on the id selected
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpdateFirstAider(int? id)
        {
            var Staffs = await _context.Staff.FindAsync(id);
            if (Staffs.FirstAider == true)
            {
                Staffs.FirstAider = false;
            }
            else
            {
                Staffs.FirstAider = true;
            }
            _context.Update(Staffs);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
