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
        public List<StudentModel> Students;

        public StudentService()
        {
            string text = File.ReadAllText("students.json");

            Students = JsonConvert.DeserializeObject<List<StudentModel>>(text);
        }

        public void AddStudent(StudentModel student)
        {
            Students.Add(student);

            string text = JsonConvert.SerializeObject(Students);

            File.WriteAllText("students.json", text);

        }
        public void Delete(Guid id)
        {
            Students.Remove(Students.First(i => i.Id == id));

            string text = JsonConvert.SerializeObject(Students);

            File.WriteAllText("students.json", text);
        }

        public void EditStudent(string nom, string prenom, string langage)
        {
            StudentModel student = Students.FirstOrDefault(i => i.Prenom == prenom && i.Nom == nom);
            Delete(student.Id);
            student.Langage = langage;
            AddStudent(student);
        }
    }
}

