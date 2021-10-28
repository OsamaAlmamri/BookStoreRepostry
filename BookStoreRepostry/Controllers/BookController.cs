using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using StaticData.Models;
using StaticData.Models.Repositores;
using StaticData.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StaticData.Controllers
{

    public class BookController : Controller
    {
        private readonly IBookrepository<Book> bookRepostry;
        private readonly IBookrepository<Author> authorRepostry;
        private readonly IHostingEnvironment hosting;

        public BookController (IBookrepository<Book> book, IBookrepository<Author> authorRepostry,IHostingEnvironment hosting)
        {
            this.bookRepostry = book;
            this.authorRepostry = authorRepostry;
            this.hosting = hosting;
        }

        // GET: Book

        public ActionResult Index()
        {
            var model = bookRepostry.list();
            return View(model);
        }
        public ActionResult Search(string term)
        {
            var model = bookRepostry.Search(term);
            return View("Index",model);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {

            var model = bookRepostry.find(id);
            return View(model);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            var model = new BookAuthorsViewModel
            {
                Authors = fillAuthors()

            };
            return View(model);
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
       
  
        public ActionResult Create(BookAuthorsViewModel bookAuthors)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("","Must fill all files");
                return View();
            }
                try
                {
                // TODO: Add insert logic here

              
                    var auther = authorRepostry.find(bookAuthors.AuthorId);

                    Book new_book = new Book
                    {
                        id = bookAuthors.BookId,
                        author = auther,
                        description = bookAuthors.description,
                        title = bookAuthors.title,
                        image = saveImage(bookAuthors.File),
                    };
                    bookRepostry.add(new_book);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
               // throw new Exception("error") ;
                    return View();
                }
            
           
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            var book = bookRepostry.find(id);
            var auther_id = book.author == null ? 0 : book.author.Id;
            var viewMode = new BookAuthorsViewModel
            {
                image=book.image,
                AuthorId= auther_id,
                BookId=book.id,
                description=book.description,
                title=book.title,
                Authors= fillAuthors()

            };
            return View(viewMode);
        }

        // POST: Book/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BookAuthorsViewModel viewModel)
        {
            try
            {
                // TODO: Add update logic here

                var book = bookRepostry.find(viewModel.BookId);
                book.id = viewModel.BookId;
                book.image = saveImage(viewModel.File,book.image,1);
                book.title = viewModel.title;
                book.description = viewModel.description;
                book.author = authorRepostry.find(viewModel.AuthorId);
               
                bookRepostry.update(viewModel.BookId,book);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            var book = bookRepostry.find(id);
            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book book)
        {
            try
            {
                // TODO: Add delete logic here

                bookRepostry.delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        List<Author> fillAuthors()
        {
            var authers = authorRepostry.list().ToList();
            authers.Insert(0, new Author { Id = -1, name = "please select Author" });
            return authers;
        }
        public String saveImage(IFormFile File, string old_path = null, int delete = 0)
        {
            string file_image = String.Empty;

            if (File != null)
            {
                file_image =Guid.NewGuid().ToString()+"_"+  File.FileName;
                file_image = Path.Combine("uploads", file_image);
                string fullPath = Path.Combine(hosting.WebRootPath, file_image);

                File.CopyTo(new FileStream(fullPath, FileMode.Create));

                if (delete == 1 && old_path != null)
                {
                    try
                    {
                        fullPath = Path.Combine(hosting.WebRootPath, old_path);
                        System.IO.File.Delete(fullPath);
                    }
                               catch
                    {
                        return file_image;
                    }
               
                }
                return file_image;
            }

            return old_path;


        }

    }
}