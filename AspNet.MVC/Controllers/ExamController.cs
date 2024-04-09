using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var authors = new[]
            {
                new Author { Id = 1, Ime = "Danijel", Prezime = "Pobi" },
                new Author { Id = 2, Ime = "Janica", Prezime = "Kostelic" },
                new Author { Id = 3, Ime = "Ivica", Prezime = "Peric" }
            };

            var books = new[]
            {
                new Book { Id = 1, ImeKnjige = "ASP.NET", Author = authors[0] },
                new Book { Id = 2, ImeKnjige = "Skijanje", Author = authors[1] },
                new Book { Id = 3, ImeKnjige = "Ivica", Author = authors[2] },
                new Book { Id = 4, ImeKnjige = "Backend", Author = authors[0] },
                new Book { Id = 5, ImeKnjige = "Klizanje", Author = authors[1] }
            };
            return View(books);
        }
    }
}
