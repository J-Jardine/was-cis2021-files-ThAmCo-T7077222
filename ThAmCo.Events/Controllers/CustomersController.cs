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
    /// Controller for customers
    /// </summary>
    public class CustomersController : Controller
    {
        /// <summary>
        /// Allowing EventsDbContext to be used
        /// </summary>
        private readonly EventsDbContext _context;

        /// <summary>
        /// Initialises the customer controller
        /// </summary>
        /// <param name="context"></param>
        public CustomersController(EventsDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        /// <summary>
        /// Gets a view of all the customers
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var customerDb = _context.Customers;
            var customers = await customerDb.ToListAsync();

            List<Models.CustomerIndexViewModel> customerIndex = new List<Models.CustomerIndexViewModel>();
            foreach (Customer e in customers)
            {
                Models.CustomerIndexViewModel customerViewModel = new Models.CustomerIndexViewModel();
                customerViewModel.Id = e.Id;
                customerViewModel.FullName = e.FirstName + " " + e.Surname;
                customerViewModel.Email = e.Email;
                customerIndex.Add(customerViewModel);
            }

            return View(customerIndex);
        }

        // GET: Customers/Details/5
        /// <summary>
        /// Gets a view of the customer detials matching to the id selected
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.Select(c => new Models.CustomerDetailsViewModel
            {
                Id = c.Id,
                FirstName = c.FirstName,
                Surname = c.Surname,
                Email = c.Email,
                FullName = c.FirstName + " " + c.Surname,
                Events = _context.Guests.Where(g => g.CustomerId == c.Id).Select(e => new Event
                {
                    Date = e.Event.Date,
                    Title = e.Event.Title,
                })
            }).FirstOrDefaultAsync(m => m.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        /// <summary>
        /// Pulls the create view model so a new customer can be added
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Adds a new customer to the database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Surname,FirstName,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        /// <summary>
        /// Gets the edit view for a customer matching the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Puts the edited details into the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Surname,FirstName,Email")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        /// <summary>
        /// Pulls the delete view for deleting a customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        /// <summary>
        /// Deletes a customer from the database matching the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            customer.FirstName = "null";
            customer.Surname = "null";
            customer.Email = "null@null.null";
            
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
