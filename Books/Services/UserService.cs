using Books.Models;
using Books.Repositories;
using System.Collections.Generic;

namespace Books.Services
{
    public class UserService
    {
        private readonly UserRepository userRepo;

        public UserService(UserRepository _userRepo)
        {
            userRepo = _userRepo;
        }

        public List<User> GetAll()
        {
            return userRepo.GetAll();
        }

        public void Add(User user)
        {
            userRepo.Add(user);
        }
    }
}
