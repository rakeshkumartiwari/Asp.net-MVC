using CatShelterMVC.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CatShelterMVC.Controllers
{
    public class CatController : Controller
    {
        CatDb _db = new CatDb();
      
        public ActionResult Index(string search = null)
        {
            var model =
                from r in _db.Cats
                orderby r.Name
                where search == null || r.Name.StartsWith(search)
                select r;
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Cat",model);
            }
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _db.Cats.Where(c => c.Id == id).ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cat cat)
        {
            if (ModelState.IsValid)
            {
                _db.Cats.Add(cat);
                _db.SaveChanges();
                return RedirectToAction("Index", "Cat");
            }

            return View(cat);
        }

        public ActionResult Edit(int id)
        {
            var model = _db.Cats.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Cat cat)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(cat).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", "Cat");
            }

            return View(cat);
        }

        public ActionResult Delete(int id)
        {
            Cat cat = _db.Cats.Find(id);
            return View(cat);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Cat cat = _db.Cats.Find(id);
            _db.Cats.Remove(cat);
            _db.SaveChanges();
            return RedirectToAction("Index", "Cat");
        }
        protected override void Dispose(bool disposing)
        {

            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}