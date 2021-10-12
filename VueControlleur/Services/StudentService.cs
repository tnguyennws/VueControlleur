using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using VueControlleur.Models;
using Newtonsoft.Json;

namespace VueControlleur.Services
{
    public class StudentService
    {
        public IEnumerable<StudentModel> Students;

        public StudentService()
        {
            string text = File.ReadAllText("students.json");

            Students = JsonConvert.DeserializeObject<IEnumerable<StudentModel>>(text);
        }
    }
}
