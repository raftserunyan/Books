using Books.Models;
using Books.Repositories;
using System.Collections.Generic;

namespace Books.Services
{
    public class UserService
    {
        private readonly UserRepository userRepo;
        private readonly BookRepository bookRepo;

        public UserService(UserRepository _userRepo, BookRepository _bookRepo)
        {
            userRepo = _userRepo;
            bookRepo = _bookRepo;
        }

        public List<User> GetAll()
        {
            return userRepo.GetAll();
        }

        public List<User> GetAllWithBooksByName(string name)
        {
            return userRepo.GetAllWithBooksByName(name);
        }

        public void Add(User user)
        {
            userRepo.Add(user);
        }

        public void AddBook(int userId, int bookId)
        {
            User user = userRepo.GetById(userId);
            BookModel book = bookRepo.GetById(bookId);

            user.Books.Add(book);
            userRepo.SaveChanges();
        }
    }
}
