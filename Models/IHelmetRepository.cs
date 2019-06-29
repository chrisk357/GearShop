using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public interface IHelmetRepository
    {
        IEnumerable<Helmet> GetAllHelmets();
        Helmet GetHelmetById(int helmetId);
    }
}

