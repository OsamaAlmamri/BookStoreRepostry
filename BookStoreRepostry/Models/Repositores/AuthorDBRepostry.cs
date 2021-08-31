using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreRepostry.Models.Repositores
{
    public class AuthorDBRepostry : IBookrepository<Author>
    {
      
        private readonly BookStoreDBContext db;

        public AuthorDBRepostry(BookStoreDBContext bookStoreDBContext)
        {
            this.db = bookStoreDBContext;
        }

        public Author find(int id)
        {
            var author = db.Authors.FirstOrDefault(e => e.Id == id);
            return author;
        }

      

        public void delete(int id)
        {
            var author = find(id);
            db.Authors.Remove(author);
            db.SaveChanges();
        }

        public IList<Author> list()
        {
            return db.Authors.ToList();
        }

        public void update(int id, Author newItem)
        {
            var author = find(id);
            author.name = newItem.name;
            db.SaveChanges();
            
        }

        public void add(Author author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
        }

        public IList<Author> Search(string term)
        {
            throw new NotImplementedException();
        }
    }
}
