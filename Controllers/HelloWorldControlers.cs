using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace DemoMVCHung.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome()
        {
            return "Welcome to my ASP.NET Core MVC application!";
        }
    }
}