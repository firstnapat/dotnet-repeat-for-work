using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Data;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class StudentController : Controller
    {   
        private readonly ApplicationDBContext _dbContext;

        public StudentController(ApplicationDBContext dbContext)
        { 
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {   
            IEnumerable <Student> allStudents = _dbContext.Students;
            return View(allStudents);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {   
            _dbContext.Students.Add(obj);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}