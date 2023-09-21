using Microsoft.AspNetCore.Mvc;
using Opg9._1.Models;
using System.Diagnostics;

namespace Opg9._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string name;
            int age;
            DateTime birthdate;

            name = "Mikkel";
            age = 25;
            birthdate = new DateTime(1995, 10, 10);

            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Birthdate = birthdate;

            return View();
        }
        public IActionResult Rockbands()
        {
            string[] rockbands = new string[] { "Metallica", "Iron Maiden", "AC/DC", "Guns N' Roses",
                           "Queen", "Led Zeppelin", "Van Halen", "Green Day", "Evanessence" };
            ViewBag.Rockbands = rockbands;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}