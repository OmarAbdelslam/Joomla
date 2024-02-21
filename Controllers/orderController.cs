using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile_Market.Models;
using Mobile_Market.Models.DBwork;

namespace Mobil_Market.Controllers
{
    public class orderController : Controller
    {
        private dbcontext dbcontext;

        public orderController(dbcontext _dbcontext)
        {
            dbcontext = _dbcontext;
        }
        // GET: orderController
        public ActionResult Index()
        {
            var arr = dbcontext.orders.ToList();   
            return View(arr);
        }

        // GET: orderController/Details/5
        public ActionResult Details(int id)
        {
            var arr =dbcontext.orders.FirstOrDefault(x=>x.orderid == id);

            return View(arr);
        }

        // GET: orderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: orderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order _order)
        {
            try
            {
                var arr = dbcontext.orders.Add(_order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: orderController/Edit/5
      /*  public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: orderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: orderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: orderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
