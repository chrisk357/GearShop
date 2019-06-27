using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public interface IJerseyRepository
    {
        IEnumerable<Jersey> GetAllJerseys();
        Jersey GetJerseyById(int jerseyId);

    }
}
