using Microsoft.AspNetCore.Mvc;
using WebTaskLayout.DAL;
using WebTaskLayout.Models;

namespace WebTaskLayout.Controllers
{
    public class GroupController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public GroupController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            
                List<Group> groups = _appDbContext.Groups.ToList();
                return View(groups);
            
        }
    }
}
