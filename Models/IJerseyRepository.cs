using System.Collections.Generic;

namespace GearShop.Models
{
    public interface IJerseyRepository
    {
        IEnumerable<Jersey> GetAllJerseys();
        Jersey GetJerseyById(int jerseyId);

    }
}
