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
            // Fiz a lista do Boletim, mas não entendi como fazer a chamada dela
            List<Boletim> alunoBoletim = new List<Boletim>();

            alunoBoletim.Add(new Boletim()
            {
                Materia = "Português",
                Nota1 = 5,
                Nota2 = 6.5,
                Nota3 = 6.5,
                //Deixar um valor nulo para nota 4
                Status = "Reprovado"
            });

            alunoBoletim.Add(new Boletim()
            {
                Materia = "Matemática",
                Nota1 = 10,
                Nota2 = 8,
                Nota3 = 8,
                Nota4 = 8,
                Status = "Aprovado"
            });

            alunoBoletim.Add(new Boletim()
            {
                Materia = "Ciências",
                Nota1 = 6,
                Nota2 = 7.5,
                Nota3 = 8,
                Nota4 = 8,
                Status = "Aprovado"
            });

            alunoBoletim.Add(new Boletim()
            {
                Materia = "História",
                Nota1 = 8,
                Nota2 = 9,
                Nota3 = 10,
                Nota4 = 7.5,
                Status = "Aprovado"
            });

            return View(alunoBoletim);
/*
            List<Person> people = new List<Person>();

            people.Add(new Person()
            {
                Id = 1,
                Name = "Willian",
                Sobrenome = "Sant Anna",
                Status = "Reprovado"

            });

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
*/
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