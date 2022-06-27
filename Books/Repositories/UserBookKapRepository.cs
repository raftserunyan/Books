using Books.Data;
using Books.Models;
using System.Collections.Generic;
using System.Linq;

namespace Books.Repositories
{
    public class UserBookKapRepository
    {
        private readonly BooksDBContext context;

        public UserBookKapRepository(BooksDBContext _context)
        {
            context = _context;
        }

        public List<UserBookKap> GetAll()
        {
            return context.UserBookKaps.ToList();
        }

        public void Add(UserBookKap newKap)
        {
            context.Add(newKap);
            context.SaveChanges();
        }
    }
}
