using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public interface IPantRepository
    {
        IEnumerable<Pant> GetAllPants();
        Pant GetPantById(int pantId);

    }
}
