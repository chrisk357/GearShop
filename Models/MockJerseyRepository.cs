using System.Collections.Generic;
using System.Linq;

namespace GearShop.Models
{
    public class MockJerseyRepository : IJerseyRepository
    {
        private List<Jersey> _jerseys;
        public MockJerseyRepository()
        {
            if (_jerseys == null)
            {
                InitializeJerseys();
            }

        }
        public void InitializeJerseys()
        {
            _jerseys = new List<Jersey>
            {
                new Jersey{JId = 1, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Red/Black", JSize = "L", JPrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                new Jersey{JId = 2, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Red/Black", JSize = "XL", JPrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                new Jersey{JId = 3, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Blue/White", JSize = "S", JPrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                new Jersey{JId = 4, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Blue/White", JSize = "M", JPrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                new Jersey{JId = 5, JBrand = "Fox", JModel = "2019 180 Model", JColor = "Green/Yellow", JSize = "XS", JPrice = 39.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                new Jersey{JId = 6, JBrand = "Fox", JModel = "2019 180 Model", JColor = "Green/Yellow", JSize = "M", JPrice = 39.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },

            };
        }
        public IEnumerable<Jersey> GetAllJerseys()
        {
            return _jerseys;
        }

        public Jersey GetJerseyById(int jerseyId)
        {
            return _jerseys.FirstOrDefault(j => j.JId == jerseyId);
        }
    }
}
