using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTaskLayout.DAL;
using WebTaskLayout.Models;
using WebTaskLayout.ViewModel;

namespace WebTaskLayout.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public StudentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public  IActionResult Index()
        {
            List<Student> students = _appDbContext.Students.ToList();
            return View(students);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Create(string name)
        {
            return View();
        }
    }
}
