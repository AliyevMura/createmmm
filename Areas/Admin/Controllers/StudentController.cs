using Microsoft.AspNetCore.Mvc;
using WebTaskLayout.DAL;
using WebTaskLayout.Models;


namespace WebTaskLayout.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        
        private readonly AppDbContext _appDbContext;
        
        public StudentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [Area("Admin")]


        public IActionResult Index()
        {
            List<Student> students =_appDbContext.Students.ToList();
            return View(students);
        }
      

    }
}
