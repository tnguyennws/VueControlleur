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

namespace VueControlleur.Controllers
{
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
    }
}
