using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public class JerseyRepository : IJerseyRepository
    {
        private readonly AppDbContext _appDbContext;

        public JerseyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Jersey> GetAllJerseys()
        {
            return _appDbContext.Jerseys;
        }

        public Jersey GetJerseyById(int jerseyId)
        {
            return _appDbContext.Jerseys.FirstOrDefault(j => j.JId == jerseyId);
        }
    }
}
