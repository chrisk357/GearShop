using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace GearShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Jerseys.Any())
            {
                context.AddRange
                    (
                    new Jersey { JId = 1, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Red/Black", JSize = "L", JPrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                    new Jersey { JId = 2, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Red/Black", JSize = "XL", JPrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                    new Jersey { JId = 3, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Blue/White", JSize = "S", JPrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                    new Jersey { JId = 4, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Blue/White", JSize = "M", JPrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                    new Jersey { JId = 5, JBrand = "Fox", JModel = "2019 180 Model", JColor = "Green/Yellow", JSize = "XS", JPrice = 39.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false },
                    new Jersey { JId = 6, JBrand = "Fox", JModel = "2019 180 Model", JColor = "Green/Yellow", JSize = "M", JPrice = 39.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false }

                    );
                context.SaveChanges();
            }

            if (!context.Pants.Any())
            {
                context.AddRange
                    (
                    new Pant { PId = 1, PBrand = "Fox", PModel = "2019 360 Model", PColor = "Red/Black", PSize = "34", PPrice = 99.99, PImageUrl = "", IsPOfTheWeek = false },
                    new Pant { PId = 2, PBrand = "Fox", PModel = "2019 360 Model", PColor = "Red/Black", PSize = "36", PPrice = 89.99, PImageUrl = "", IsPOfTheWeek = false },
                    new Pant { PId = 3, PBrand = "Fox", PModel = "2019 360 Model", PColor = "Blue/White", PSize = "30", PPrice = 89.99, PImageUrl = "", IsPOfTheWeek = false },
                    new Pant { PId = 4, PBrand = "Fox", PModel = "2019 180 Model", PColor = "Green/Yellow", PSize = "26", PPrice = 59.99, PImageUrl = "", IsPOfTheWeek = false },
                    new Pant { PId = 5, PBrand = "Fox", PModel = "2019 180 Model", PColor = "Blue/White", PSize = "30", PPrice = 59.99, PImageUrl = "", IsPOfTheWeek = false },
                    new Pant { PId = 6, PBrand = "Fox", PModel = "2019 180 Model", PColor = "Green/Yellow", PSize = "28", PPrice = 49.99, PImageUrl = "", IsPOfTheWeek = false }
                    );
                context.SaveChanges();
            }
        }
    }
}