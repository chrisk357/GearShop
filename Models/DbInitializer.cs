using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace GearShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();
                        if (!context.Jerseys.Any())
                        {
                            context.AddRange
                                (
                                new Jersey { JId = 1, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Red/Black", JSize = "L", JPrice = 59.99, JSalePrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false, JQuantityOnHand = 12},
                                new Jersey { JId = 2, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Red/Black", JSize = "XL", JPrice = 59.99, JSalePrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false, JQuantityOnHand = 20},
                                new Jersey { JId = 3, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Blue/White", JSize = "S", JPrice = 59.99, JSalePrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false, JQuantityOnHand = 9},
                                new Jersey { JId = 4, JBrand = "Fox", JModel = "2019 360 Model", JColor = "Blue/White", JSize = "M", JPrice = 59.99, JSalePrice = 59.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false, JQuantityOnHand = 11},
                                new Jersey { JId = 5, JBrand = "Fox", JModel = "2019 180 Model", JColor = "Green/Yellow", JSize = "XS", JPrice = 39.99, JSalePrice = 39.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false, JQuantityOnHand = 14},
                                new Jersey { JId = 6, JBrand = "Fox", JModel = "2019 180 Model", JColor = "Green/Yellow", JSize = "M", JPrice = 39.99, JSalePrice = 39.99, JImageUrl = "https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png", IsJOfTheWeek = false, JQuantityOnHand = 15}

                                );
                            context.SaveChanges();
                        }

                        if (!context.Pants.Any())
                        {
                            context.AddRange
                                (
                                new Pant { PId = 1, PBrand = "Fox", PModel = "2019 360 Model", PColor = "Red/Black", PSize = 34, PPrice = 99.99, PSalePrice = 99.99, PImageUrl = "", IsPOfTheWeek = false, PQuantityOnHand = 9 },
                                new Pant { PId = 2, PBrand = "Fox", PModel = "2019 360 Model", PColor = "Red/Black", PSize = 36, PPrice = 89.99, PSalePrice = 89.99, PImageUrl = "", IsPOfTheWeek = false, PQuantityOnHand = 9 },
                                new Pant { PId = 3, PBrand = "Fox", PModel = "2019 360 Model", PColor = "Blue/White", PSize = 30, PPrice = 89.99, PSalePrice = 89.99, PImageUrl = "", IsPOfTheWeek = false, PQuantityOnHand = 15 },
                                new Pant { PId = 4, PBrand = "Fox", PModel = "2019 180 Model", PColor = "Green/Yellow", PSize = 26, PPrice = 59.99, PSalePrice = 59.99, PImageUrl = "", IsPOfTheWeek = false, PQuantityOnHand = 10 },
                                new Pant { PId = 5, PBrand = "Fox", PModel = "2019 180 Model", PColor = "Blue/White", PSize = 30, PPrice = 59.99, PSalePrice = 59.99, PImageUrl = "", IsPOfTheWeek = false, PQuantityOnHand = 15 },
                                new Pant { PId = 6, PBrand = "Fox", PModel = "2019 180 Model", PColor = "Green/Yellow", PSize = 28, PPrice = 49.99, PSalePrice = 49.99, PImageUrl = "", IsPOfTheWeek = false, PQuantityOnHand = 12 }
                                );
                            context.SaveChanges();
                        }

                         if (!context.Helmets.Any())
                        {
                            context.AddRange
                                (
                                new Helmet { HId = 1, HBrand = "Arai", HModel = "2019 360 Model", HColor = "Red/Black", HSize = "S", HPrice = 219.99, HSalePrice = 219.99, HImageUrl = "", IsHOfTheWeek = false, HQuantityOnHand = 14},
                                new Helmet { HId = 2, HBrand = "Arai", HModel = "2019 360 Model", HColor = "Red/Black", HSize = "M", HPrice = 299.99, HSalePrice = 279.99, HImageUrl = "", IsHOfTheWeek = false, HQuantityOnHand = 15},
                                new Helmet { HId = 3, HBrand = "Suomy", HModel = "2019 360 Model", HColor = "Blue/White", HSize = "XS", HPrice = 199.99, HSalePrice = 199.99, HImageUrl = "", IsHOfTheWeek = false, HQuantityOnHand = 10},
                                new Helmet { HId = 4, HBrand = "Suomy", HModel = "2019 180 Model", HColor = "Green/Yellow", HSize = "XL", HPrice = 419.99, HSalePrice = 399.99, HImageUrl = "", IsHOfTheWeek = false, HQuantityOnHand = 10},
                                new Helmet { HId = 5, HBrand = "Bell", HModel = "2019 180 Model", HColor = "Blue/White", HSize = "L", HPrice = 359.99, HSalePrice = 359.99, HImageUrl = "", IsHOfTheWeek = false, HQuantityOnHand = 13},
                                new Helmet { HId = 6, HBrand = "Bell", HModel = "2019 180 Model", HColor = "Green/Yellow", HSize = "M", HPrice = 349.99, HSalePrice = 349.99, HImageUrl = "", IsHOfTheWeek = false, HQuantityOnHand = 9}
                                );
                            context.SaveChanges();
                        }

                    
        }
    }
}