using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {   
            return View();
        }
        public IActionResult Details()
        {
            return Content("รายละเอียดคะแนนสอบวิชาคอมโปรแกรมมิ่ง 2");
     
        }
        public IActionResult ShowScore(int id)
        {
            return Content($"คะแนนสอบวิชาคอมโปรแกรมมิ่ง 2 ของนักเรียนที่มีรหัส {id}");
        }
    }
}