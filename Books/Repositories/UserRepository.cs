using Books.Data;
using Books.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Books.Repositories
{
    public class UserRepository
    {
        private readonly BooksDBContext context;

        public UserRepository(BooksDBContext _context)
        {
            context = _context;
        }

        public List<User> GetAll()
        {
            return context.Users.Include(x => x.Books).ToList();
        }

        public List<User> GetAllWithBooksByName(string name)
        {
            return context.Users.Include(x => x.Books).Where(x => x.name == name).ToList();
        }

        public void Add(User newUser)
        {
            context.Add(newUser);
            context.SaveChanges();
        }

        public User GetById(int userId)
        {
            return context.Users.Include(x => x.Books).FirstOrDefault(x => x.id == userId);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
