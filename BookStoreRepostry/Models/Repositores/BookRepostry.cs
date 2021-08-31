using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreRepostry.Models.Repositores
{
    public class BookRepostry : IBookrepository<Book>
    {
        List<Book> books;
        public BookRepostry()
        {
            books = new List<Book>()
            {
                new Book{id=1,title="C#",description="no description"},
                new Book{id=2,title="java",description="no description"},
                new Book{id=3,title="asp",description="no description"},
            };
        }

        public Book find(int id)
        {
            var book = books.FirstOrDefault(e => e.id == id);
            return book;
        }

      

        public void delete(int id)
        {
            var book = find(id);
            books.Remove(book);
        }

        public IList<Book> list()
        {
            return books;
        }

        public void update(int id, Book newItem)
        {
            var book = find(id);
            book.title = newItem.title;
            book.description = newItem.description;
            book.author = newItem.author;
            book.image = newItem.image;
            
        }

        public void add(Book book)
        {
            books.Add(book);
        }

        public IList<Book> Search(string term)
        {
            throw new NotImplementedException();
        }
    }
}
