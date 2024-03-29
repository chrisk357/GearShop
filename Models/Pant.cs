﻿using System.ComponentModel.DataAnnotations;

namespace GearShop.Models
{
    public class Pant
    {
        [Key]
        public int PId { get; set; }
        public string PBrand { get; set; }
        public string PModel { get; set; }
        public string PColor { get; set; }
        public int PSize { get; set; }
        public double PPrice { get; set; }
        public double PSalePrice { get; set; }
        public string PImageUrl { get; set; }
        public bool IsPOfTheWeek { get; set; }
        public int PQuantityOnHand { get; set; }

    }
}
