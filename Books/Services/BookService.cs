using Books.Models;
using Books.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Books.Services
{
    public class BookService
    {
        private readonly BookRepository bookRepo;

        public BookService(BookRepository _bookRepo)
        {
            bookRepo = _bookRepo;
        }

        public List<BookModel> GetAll()
        {
            return bookRepo.GetAll();
        }

        public BookModel GetById(int id)
        {
            BookModel book = new List<BookModel>().FirstOrDefault(b => b.Id == id);

            if(book == null)
            {
                throw new Exception("No Book With that id");
            }

            return book;
        }
        public BookModel GetByName(string name)
        {
            BookModel book = new List<BookModel>().FirstOrDefault(b => b.Name.ToUpper() == name.ToUpper());

            if (book == null)
            {
                throw new Exception("No Book With that name");
            }

            return book;
        }
        public List<BookModel> GetByAuthor(string author)
        {
            return new List<BookModel>().Where(book => book.Author.ToUpper() == author.ToUpper()).ToList();
        }
        public List<BookModel> GetByProductionYear(int year)
        {
            return new List<BookModel>().Where(book => book.ProductionYear == year).ToList();
        }
        public List<BookModel> GetByDescription(string description)
        {
            return new List<BookModel>().Where(book => book.Description.ToUpper() == description.ToUpper()).ToList();
        }
        public List<BookModel> GetByTotalCount(int totalCount)
        {
            return new List<BookModel>().Where(book => book.TotalCount == totalCount).ToList();
        }
        public List<BookModel> GetByBorrowingCount(int totalCount)
        {
            return new List<BookModel>().Where(book => book.TotalCount == totalCount).ToList();
        }
        public List<BookModel> GetByUsingCount(int usingCount)
        {
            return new List<BookModel>().Where(book => book.TotalCount == usingCount).ToList();
        }
        public List<BookModel> GetByGenre(string genre)
        {
            return new List<BookModel>().Where(book => book.Genre == genre).ToList();
        }

        // HttpPost
        public void Add(BookModel newBook)
        {
            bookRepo.Add(newBook);
        }

        // HttpDelete

        public void DeleteBookById(int id)
        {
            BookModel book = new List<BookModel>().FirstOrDefault(student => student.Id == id);

            if (book == null)
            {
                throw new Exception("No Book with that Id");
            }

            new List<BookModel>().Remove(book);
        }

        public void DeleteBookByName(string name)
        {
            new List<BookModel>().RemoveAll(book => book.Name.ToUpper() == name.ToUpper());
        }
        public void DeleteBookByAuthor(string author)
        {
            new List<BookModel>().RemoveAll(book => book.Author.ToUpper() == author.ToUpper());
        }
        public void DeleteBookByGenre(string genre)
        {
            new List<BookModel>().RemoveAll(book => book.Genre.ToUpper() == genre.ToUpper());
        }
        
        public void Update(BookModel updatedBook)
        {
            BookModel book = new List<BookModel>().FirstOrDefault(b => b.Id == updatedBook.Id);

            if(book == null)
            {
                throw new Exception("No book with that Id");
            }
            else if(updatedBook.TotalCount != updatedBook.AvailibleForBorrowngCount + updatedBook.AvailibleForUsingInLibraryCount)
            {
                throw new Exception("Invalid data");
            }

            book.Author = updatedBook.Author;
            book.AvailibleForBorrowngCount = updatedBook.AvailibleForBorrowngCount;
            book.AvailibleForUsingInLibraryCount = updatedBook.AvailibleForUsingInLibraryCount;
            book.Description = updatedBook.Description;
            book.Genre = updatedBook.Genre;
            book.Name = updatedBook.Name;
            book.PagesCount = updatedBook.PagesCount;
            book.ProductionYear = updatedBook.ProductionYear;
            book.TotalCount = updatedBook.TotalCount;
        }
    }
}