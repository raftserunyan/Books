using Books.Data;
using Books.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Books.Repositories
{
    public class BookRepository
    {
        private readonly BooksDBContext context;

        public BookRepository(BooksDBContext _context)
        {
            context = _context;
        }

        public List<BookModel> GetAll()
        {
            return context.Books.ToList();
        }

        public void Add(BookModel newBook)
        {
            context.Add(newBook);
            context.SaveChanges();
        }
    }
}