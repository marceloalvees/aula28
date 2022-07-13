using Aula28.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aula28.Controllers
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
            List<Person> people = new List<Person>();

            people.Add(new Person()
            {
                Id = 1,
                Name = "Willian",
                Sobrenome = "Sant Anna",
                Status = "Reprovado"

            }) ;

            people.Add(new Person()
            {
                Id = 2,
                Name = "Alan ",
                Sobrenome = "Santana",
                Status = "Aprovado"

            });

            people.Add(new Person()
            {
                Id = 3,
                Name = "Lais ",
                Sobrenome = "Baltar",
                Status = "Aprovado"

            });

            people.Add(new Person()
            {
                Id = 4,
                Name = "Marcelo ",
                Sobrenome = "Alves",
                Status = "Recuperação"

            });



            return View(people);
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