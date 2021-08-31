using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreRepostry.Models.Repositores
{
    public class BookDBRepostry : IBookrepository<Book>
    {
       
        private readonly BookStoreDBContext db;

        public BookDBRepostry(BookStoreDBContext db)
        {
            this.db = db;
        }

        public Book find(int id)
        {
            var book = db.Books.Include(e => e.author).FirstOrDefault(e => e.id == id);
            return book;
        }

      

        public void delete(int id)
        {
            var book = find(id);
            db.Books.Remove(book);
            db.SaveChanges();
        }

        public IList<Book> list()
        {
            return db.Books.Include(e=>e.author).ToList();
        }

        public void update(int id, Book newItem)
        {
            db.Books.Update(newItem);
            db.SaveChanges();

        }

        public void add(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public IList<Book> Search(string trem)
        {
            var result = db.Books.Include(a=>a.author).Where(b=>
            b.description.Contains(trem) || b.title.Contains(trem) || b.author.name.Contains(trem)).ToList();
            return result;

        }
    }
}
