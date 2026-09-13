using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace DemoMVCHung.Controllers
{
    public class Lesson1Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Xin chào sinh viên HUMG!";
            ViewBag.Name = "Trương Ngọ Duy Hùng";

            return View();
        }

        [HttpPost]
        public IActionResult Index(string HoTen, int Tuoi)
        {
            ViewBag.Message = "Đã nhận dữ liệu!";
            ViewBag.HoTen = HoTen;
            ViewBag.Tuoi = Tuoi;

            return View();
        }
    }
}