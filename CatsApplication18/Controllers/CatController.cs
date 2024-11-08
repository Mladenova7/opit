using CatsApplication18.Data;
using CatsApplication18.Entities;
using CatsApplication18.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace CatsApplication18.Controllers
{
    public class CatController : Controller
    {
        ApplicationDBContext _db;
        public CatController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var list=_db.cats.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cat obj)
        {
            if(obj.Age==0)
            {
                ModelState.AddModelError("Age", "Wrong age");
            }

            if (ModelState.IsValid)
            {
                _db.cats.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
          return View();    
        }
    }
}
