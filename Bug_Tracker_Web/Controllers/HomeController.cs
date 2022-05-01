using Bug_Tracker_Web.Data;
using Bug_Tracker_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bug_Tracker_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }


        public IActionResult Index()
        {
            return this.View();
        }
        //public IActionResult Mathode()
        //{
        //    List<Projects> objCategoryList = _db.Projects.ToList();
        //    return PartialView(objCategoryList);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}