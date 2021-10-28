using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StaticData.Controllers
{
    [AllowAnonymous]
    public class FDBsController : Controller
    {
        // GET: FDBTypesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FDBTypesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FDBTypesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FDBTypesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: FDBTypesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FDBTypesController/Edit/5
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

        // GET: FDBTypesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FDBTypesController/Delete/5
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
        }
    }
}
