using Microsoft.AspNetCore.Mvc;
using DemoMVCHung.Models;

namespace DemoMVCHung.Controllers
{
    public class Lesson2Controller : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student
            {
                Id = 1,
                HoTen = "Duy Hùng",
                Tuoi = 20,
                Diem = 8.5
            };

            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            return View("Index", student);
        }
    }
}