using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVCCore.Models;

namespace WebApplicationMVCCore.Controllers
{
    public class Student1Controller : Controller
    {
        List<Student> listStudents = null;

        private void InitializeStudents()
        {
            listStudents = new List<Student>()
            {
                 new Student() { Id=1 , Name="Ajay", Batch="B001", Marks=90},
                 new Student() { Id=2 , Name="Deepak", Batch="B002", Marks=98},
                 new Student() { Id=3 , Name="Jay", Batch="B001", Marks=91},
                 new Student() { Id=4 , Name="Vijay", Batch="B003", Marks=93},
                 new Student() { Id=5 , Name="Abhi", Batch="B002", Marks=89},
                 new Student() { Id=6 , Name="Gagan", Batch="B002", Marks=78}
            };
        }

        public Student1Controller()
        {
            if (listStudents == null)
                InitializeStudents();
        }

        public IActionResult Index()
        {
            return View(listStudents);
        }

        public IActionResult Details(int id)
        {
            // LINQ > Language Integrated Query Language 
            var student = listStudents.FirstOrDefault(x => x.Id == id);
            //if (student != null)
                return View(student);
            //else
            //    ViewBag.message = "Student not found";
            //return View();

        }
    }
}
