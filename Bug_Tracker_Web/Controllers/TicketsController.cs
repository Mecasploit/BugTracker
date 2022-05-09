using Bug_Tracker_Web.Data;
using Bug_Tracker_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bug_Tracker_Web.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TicketsController(ApplicationDbContext db) // here i can access what is in the container! 
        {
            _db = db; 
        }

        // GET: CategoryController
        public ActionResult Index(int Id)
        {
            if (Id == null || Id ==0)
            {
                return NotFound();
            }

            var ProjectFromDb = _db.Projects.Find(Id);
            // Select from the Tickets only the ones related to the sent project
            List<Tickets> objCategoryList = _db.Tickets.Where(b => b.ProjectId == Id).ToList();

            ViewBag.Status = ProjectFromDb.Status;
            ViewBag.Date = ProjectFromDb.DateOfCreation.ToString().Split(" ")[0];
            ViewData["WalidData"] = "SalamoAlaikom test!";

            return View(objCategoryList);
        }

        // GET
        public ActionResult Create()
        { 
            return View();
        }
        /*
        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken] // to avoid Cross Site Requist Forgery...
        public ActionResult Create(Tickets obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "wa sir tqaewd rahoum fhal fhal.");
            }
            if (ModelState.IsValid)
            {
                _db.Tickets.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public ActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Tickets.Find(id);

            if(categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }
        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken] // to avoid Cross Site Requist Forgery...
        public ActionResult Edit(Tickets obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "wa sir tqaewd rahoum fhal fhal.");
            }
            if (ModelState.IsValid)
            {
                _db.Tickets.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public ActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Tickets.Find(id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }
        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken] // to avoid Cross Site Requist Forgery...
        public ActionResult DeletePOST(int? id)
        {
            var obj = _db.Tickets.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Tickets.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
            
        }
        */

    }
}
