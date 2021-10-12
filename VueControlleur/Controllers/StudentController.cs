using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VueControlleur.Models;

namespace VueControlleur.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View("StudentView", new []
            {
                new StudentModel
                {
                    Prenom = "Raphaël",
                    Nom = "Masse",
                    Langage = "PHP"
                },
                new StudentModel
                {
                    Prenom = "Nicolas",
                    Nom = "Vareille",
                    Langage = "C#"
                },
                new StudentModel
                {
                    Prenom = "Timothée",
                    Nom = "Nguyen",
                    Langage = "C#"
                },
                new StudentModel
                {
                    Prenom = "Dylan",
                    Nom = "Couto De Oliveira",
                    Langage = "PHP"
                },
            });
        }
    }
}
