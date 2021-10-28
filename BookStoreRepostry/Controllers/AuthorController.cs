using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaticData.Models;
using StaticData.Models.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace StaticData.Controllers
{
    
    public class AuthorController : Controller
    {
        private readonly IBookrepository<Author> authorRepostrt;

        // GET: Author

        public AuthorController(IBookrepository<Author> authorRepostrt)
        {
            this.authorRepostrt = authorRepostrt;
        }
        public ActionResult Index()
        {
            var list = authorRepostrt.list();
            return View(list);
        }

        // GET: Author/Details/5
        public ActionResult Details(int id)
        {
            var model = authorRepostrt.find(id);
            return View(model);
        }

        // GET: Author/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Author/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    // TODO: Add insert logic here

                    authorRepostrt.add(author);

                    return RedirectToAction(nameof(Details), new { id = author.Id });
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            var model = authorRepostrt.find(id);
            return View(model);
        }

        // POST: Author/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Author author)
        {
            try
            {
                // TODO: Add update logic here
                authorRepostrt.update(id, author);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Author/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Author author)
        {
            try
            {
                // TODO: Add delete logic here
                authorRepostrt.delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}