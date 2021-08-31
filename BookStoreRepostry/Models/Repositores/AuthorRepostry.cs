using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreRepostry.Models.Repositores
{
    public class AuthorRepostry : IBookrepository<Author>
    {
        List<Author> authors;
        public AuthorRepostry()
        {
            authors = new List<Author>()
            {
                new Author{Id=1,name="osama"}
            
            };
        }

        public Author find(int id)
        {
            var author = authors.FirstOrDefault(e => e.Id == id);
            return author;
        }

      

        public void delete(int id)
        {
            var author = find(id);
            authors.Remove(author);
        }

        public IList<Author> list()
        {
            return authors;
        }

        public void update(int id, Author newItem)
        {
            var author = find(id);
            author.name = newItem.name;
            
        }

        public void add(Author author)
        {
            author.Id = list().Max(e => e.Id) + 1;
            authors.Add(author);
        }

        public IList<Author> Search(string term)
        {
            throw new NotImplementedException();
        }
    }
}
