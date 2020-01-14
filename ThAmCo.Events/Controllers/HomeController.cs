using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThAmCo.Events.Models;

namespace ThAmCo.Events.Controllers
{
    /// <summary>
    /// The home controller that is the default page for Events
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index view
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// About view
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Contact view
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /// <summary>
        /// Privacy view
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Error view
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
