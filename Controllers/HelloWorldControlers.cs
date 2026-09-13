using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace DemoMVCHung.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "Welcome to my ASP.NET Core MVC application!";
        }
    }
}