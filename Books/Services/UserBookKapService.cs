using Books.Models;
using Books.Repositories;
using System.Collections.Generic;

namespace Books.Services
{
    public class UserBookKapService
    {
        private readonly UserBookKapRepository kapRepo;

        public UserBookKapService(UserBookKapRepository _kapRepo)
        {
            kapRepo = _kapRepo;
        }

        public List<UserBookKap> GetAll()
        {
            return kapRepo.GetAll();
        }

        public void Add(UserBookKap kap)
        {
            kapRepo.Add(kap);
        }
    }
}
