using System.Collections.Generic;
using System.Linq;

namespace GearShop.Models
{
    public class MockPantRepository : IPantRepository
    {

        private List<Pant> _pants;
        public MockPantRepository()
        {
            if (_pants == null)
            {
                InitializePants();
            }

        }
        public void InitializePants()
        {
            _pants = new List<Pant>
            {
                new Pant{PId = 1, PBrand = "Fox", PModel = "2019 360 Model", PColor = "Red/Black", PSize = 34, PPrice = 99.99, PImageUrl = "", IsPOfTheWeek = false },
                new Pant{PId = 2, PBrand = "Fox", PModel = "2019 360 Model", PColor = "Red/Black", PSize = 36, PPrice = 89.99, PImageUrl = "", IsPOfTheWeek = false },
                new Pant{PId = 3, PBrand = "Fox", PModel = "2019 360 Model", PColor = "Blue/White", PSize = 30, PPrice = 89.99, PImageUrl = "", IsPOfTheWeek = false },
                new Pant{PId = 4, PBrand = "Fox", PModel = "2019 180 Model", PColor = "Green/Yellow", PSize = 26, PPrice = 59.99, PImageUrl = "", IsPOfTheWeek = false },
                new Pant{PId = 5, PBrand = "Fox", PModel = "2019 180 Model", PColor = "Blue/White", PSize = 30, PPrice = 59.99, PImageUrl = "", IsPOfTheWeek = false },
                new Pant{PId = 6, PBrand = "Fox", PModel = "2019 180 Model", PColor = "Green/Yellow", PSize = 28, PPrice = 49.99, PImageUrl = "", IsPOfTheWeek = false },

            };
        }
        public IEnumerable<Pant> GetAllPants()
        {
            return _pants;
        }

        public Pant GetPantById(int pantId)
        {
            return _pants.FirstOrDefault(p => p.PId == pantId);
        }
    }
}
