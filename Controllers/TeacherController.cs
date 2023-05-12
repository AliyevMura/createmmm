using Microsoft.AspNetCore.Mvc;
using WebTaskLayout.DAL;
using WebTaskLayout.Models;

namespace WebTaskLayout.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public TeacherController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {

            List<Teacher> teachers = _appDbContext.Teachers.ToList();
            return View(teachers);

        }
    }
}
