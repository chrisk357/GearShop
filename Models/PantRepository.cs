using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public class PantRepository : IPantRepository
    {
        private readonly AppDbContext _appDbContext;

        public PantRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public IEnumerable<Pant> GetAllPants()
        {
            return _appDbContext.Pants;
        }

        public Pant GetPantById(int pantId)
        {
            return _appDbContext.Pants.FirstOrDefault(p => p.PId == pantId);
        }
    }
}
