using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public class Helmet
    {
        [Key]
        public int HId { get; set; }
        public string HBrand { get; set; }
        public string HModel { get; set; }
        public string HColor { get; set; }
        public string HSize { get; set; }
        public double HPrice { get; set; }
        public double HSalePrice { get; set; }
        public string HImageUrl { get; set; }
        public bool IsHOfTheWeek { get; set; }
        public int HQuantityOnHand { get; set; }

    }
}
