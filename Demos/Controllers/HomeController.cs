using Demos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demos.Controllers
{
    public class HomeController : Controller
    {

        public static List<Persons> personsslist = new List<Persons>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           
            return View(personsslist);
        }

        public ActionResult Results()
        {
            
            return View(personsslist);
        }

        public ActionResult Delete(string? i)
        {
            var st = personsslist.Find(c => c.FirstName == i);
            personsslist.Remove(st);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Persons ctycreate)
        {
           
                personsslist.Add(ctycreate);
                ViewBag.message = "The user " + ctycreate.FirstName + " is saved successfully";
                return RedirectToAction("Index");
            
        }
    }
}