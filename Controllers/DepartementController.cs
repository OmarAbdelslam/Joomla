using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile_Market.Models;
using Mobile_Market.Models.DBwork;

namespace Mobil_Market.Controllers
{
    public class DepartementController : Controller
    {
        private dbcontext dbcontext;

        public DepartementController(dbcontext _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        // GET: DepartementController
        public ActionResult Index()
        {
            var arr=dbcontext.departements.ToList();
            return View(arr);
        }

        // GET: DepartementController/Details/5
        public ActionResult Details(int id)
        {
            if (id >= 0)
            {
                var arr = dbcontext.departements.FirstOrDefault<Departement>(x => x.depoNo == id);
                return View(arr);
            }
            else { return View("THE ID IS NOT FOUND"); }
        }

        // GET: DepartementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Departement _departement)
        {
            try
            {
                dbcontext.departements.Add(new Departement() { depoName = _departement.depoName });
                dbcontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartementController/Edit/5
        public ActionResult Edit(int id)
        {
            var arr = dbcontext.departements.Find(id);
            return View(arr);
        }

        // POST: DepartementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Departement collection)
        {
            try
            {
               dbcontext.departements.Update(collection);
                dbcontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartementController/Delete/5
        public ActionResult Delete(int id)
        {
           return Edit(id);
        }

        // POST: DepartementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Departement collection)
        {
            try
            {
                dbcontext.departements.Remove(collection);
                dbcontext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
