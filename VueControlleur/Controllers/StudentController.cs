using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VueControlleur.Models;
using VueControlleur.Services;
using Newtonsoft.Json;
using System.IO;

namespace VueControlleur.Controllers
{
    [Route("[Controller]/")]
    public class StudentController : Controller
    {

        public StudentService StudentService;

        public StudentController(StudentService service)
        {
            StudentService = service;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View("StudentView", StudentService.Students);
        }

        [HttpGet("create/{nom}/{prenom}/{langage}")]
        public IActionResult Create(string nom, string prenom, string langage)
        {
            var student = new StudentModel
            {
                Id = Guid.NewGuid(),
                Nom = nom,
                Prenom = prenom,
                Langage = langage
            };

            StudentService.AddStudent(student);

            return RedirectToAction("Index");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            StudentService.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet("edit/{nom}/{prenom}/{langage}")]
        public IActionResult Edit(string nom, string prenom, string langage)
        {
            StudentService.EditStudent(nom, prenom, langage);

            return RedirectToAction("Index");
        }
    }
}
