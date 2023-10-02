using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class Exercise03Controller : Controller
    {
        public IActionResult Index()
        {

            Book book1 = new Book("The Fellowship of the Ring", 10.99, "https://images-na.ssl-images-amazon.com/images/I/51%2B1j%2B8u%2BPL._SX331_BO1,204,203,200_.jpg", "J.R.R. Tolkien", "George Allen & Unwin", 1954, "978-0618640157");
            MusicCD cd1 = new MusicCD("The Dark Side of the Moon", 11.99, "https://upload.wikimedia.org/wikipedia/en/3/3b/Dark_Side_of_the_Moon.png", "Pink Floyd", "Harvest", 1973, new System.Collections.Generic.List<string> { "Speak to Me", "Breathe", "On the Run", "Time", "The Great Gig in the Sky", "Money", "Us and Them", "Any Colour You Like", "Brain Damage", "Eclipse" });


            ViewBag.Book = book1;
            ViewBag.CD = cd1;
            return View();

        }
    }
}
