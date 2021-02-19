using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChallengerCore.Controllers
{
    public class CuentaLoginController : Controller
    {
        private static string apiKEY = "AIzaSyAR1xn9seN6ID_IQBxU2FzAeDFlOAs7qZw";
        // GET: CuentaLogin
        public ActionResult Index()
        {
            return View();
        }

        // GET: CuentaLogin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuentaLogin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuentaLogin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CuentaLogin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentaLogin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CuentaLogin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuentaLogin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
