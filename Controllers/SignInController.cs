using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile_Market.Models;
using Mobile_Market.Models.DBwork;

namespace Mobil_Market.Controllers
{
    public class SignInController : Controller
    {
        private readonly dbcontext dbcontext;

        public SignInController(dbcontext _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        // Get:
        public IActionResult Details(string id)
        {
            if (ModelState.IsValid)
            {
                var arr = dbcontext.members.Find(id);
                return RedirectToAction(nameof(Dashbourd));
            }
            else
                return View();
        }


        // GET: SignInController
        public ActionResult Dashbourd()
        {
            return View();
        }

        // GET: SignInController/Details/5
        //public ActionResult Details(string id)
        //{
            
        //        var arr = dbcontext.members.Find(id);
        //        return View(arr);
        //}
          

        // GET: SignInController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SignInController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: SignInController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: SignInController/Edit/5
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit(int id, IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

    //    // GET: SignInController/Delete/5
    //    public ActionResult Delete(int id)
    //    {
    //        return View();
    //    }

    //    // POST: SignInController/Delete/5
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Delete(int id, IFormCollection collection)
    //    {
    //        try
    //        {
    //            return RedirectToAction(nameof(Index));
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }
    }
}
