using Bug_Tracker_Web.Data;
using Bug_Tracker_Web.Models;
using Microsoft.AspNetCore.Mvc;

//test for git

namespace Bug_Tracker_Web.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProjectsController(ApplicationDbContext db) // here i can access what is in the container! 
        {
            _db = db;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            List<Projects> objProjectsList = _db.Projects.ToList();
            //ViewData["WalidData"] = objProjectsList;
            return View(objProjectsList);
        }
    }
}
