using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgrammingClub.Controllers
{
    public class SidebarController : Controller
    {
        // GET: Sidebar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sidebar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sidebar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sidebar/Create
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

        // GET: Sidebar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sidebar/Edit/5
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

        // GET: Sidebar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sidebar/Delete/5
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
