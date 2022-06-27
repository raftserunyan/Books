using Books.Data;
using Books.Models;
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
            return context.Users.ToList();
        }

        public void Add(User newUser)
        {
            context.Add(newUser);
            context.SaveChanges();
        }
    }
}
