using System.Collections.Generic;

namespace GearShop.Models
{
    public interface IPantRepository
    {
        IEnumerable<Pant> GetAllPants();
        Pant GetPantById(int pantId);

    }
}
