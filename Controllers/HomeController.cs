using Microsoft.AspNetCore.Mvc;

namespace WebTaskLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //public IActionResult Show()
        //{
        //    return View();
        //}
        public IActionResult Student()
        {
            return View();
        }
        public IActionResult Teacher()
        {
            return View();
        }
        public IActionResult Group()
        {
            return View();
        }
    }
}
