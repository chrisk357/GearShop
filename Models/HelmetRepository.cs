using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public class HelmetRepository : IHelmetRepository
    {
        private readonly AppDbContext _appDbContext;
        public HelmetRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Helmet> GetAllHelmets()
        {
            return _appDbContext.Helmets;
        }
        public Helmet GetHelmetById(int helmetId)
        {
            return _appDbContext.Helmets.FirstOrDefault(h => h.HId == helmetId);
        }
    }
}

