using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {   
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "John Doe";
            s1.Score = 90;
            
            var s2 = new Student();
            s2.Id = 2;
            s2.Name = "Jane Smith";
            s2.Score = 85;

            Student s3 = new();
            s3.Id = 3;
            s3.Name = "Sam Brown";
            s3.Score = 49;

            List<Student> allStudents = new List<Student>();
            allStudents.Add(s1);
            allStudents.Add(s2);
            allStudents.Add(s3);

            return View(allStudents);
        }
        public IActionResult Create()
        {
            return View();
     
        }
    }
}