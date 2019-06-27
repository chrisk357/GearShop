using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public class Pant
    {
        public int PId { get; set; }
        public string PBrand { get; set; }
        public string PModel { get; set; }
        public string PColor { get; set; }
        public string PSize { get; set; }
        public double PPrice { get; set; }
        public string PImageUrl { get; set; }
        public bool IsPOfTheWeek { get; set; }

    }
}
