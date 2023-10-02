using Microsoft.AspNetCore.Mvc;
using Opg9._1.Models;
using System.Diagnostics;

namespace Opg9._4.Controllers
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

            return View();
        }

        public IActionResult TimeCalculator(IFormCollection formCollection)
        {
            if (formCollection.Count > 0)
            {
                int hours = Convert.ToInt32(formCollection["Hours"]);
                int minutes = Convert.ToInt32(formCollection["Minutes"]);
                int seconds = Convert.ToInt32(formCollection["Seconds"]);

                TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
                double totalSeconds = ts.TotalSeconds;

                ViewBag.Hours = hours.ToString();
                ViewBag.Minutes = minutes.ToString();
                ViewBag.Seconds = seconds.ToString();
                ViewBag.TotalSeconds = totalSeconds.ToString();
            };
            //Hvis den skal åbne nyt page så fjern index
            return View("Index");

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
    }
}