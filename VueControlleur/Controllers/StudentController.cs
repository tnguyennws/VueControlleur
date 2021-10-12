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

        public IActionResult Index()
        {
            return View("StudentView", StudentService.Students);
        }

        [HttpGet("create/{nom}/{prenom}/{langage}")]
        public IActionResult Create(string nom, string prenom, string langage)
        {
            var student = new StudentModel
            {
                Nom = nom,
                Prenom = prenom,
                Langage = langage
            };

            StudentService.AddStudent(student);

            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {


            return View();
        }

        [Route("edit/{nom}/{prenom}/{langage}")]
        public IActionResult Edit()
        {
            return View("EditView", StudentService.Students);
        }
    }
}
