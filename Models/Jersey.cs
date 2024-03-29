﻿using System.ComponentModel.DataAnnotations;

namespace GearShop.Models
{
    public class Jersey
    {
        [Key]
        public int JId { get; set; }
        public string JBrand { get; set; }
        public string JModel { get; set; }
        public string JColor { get; set; }
        public string JSize { get; set; }
        public double JPrice { get; set; }
        public double JSalePrice { get; set; }
        public string JImageUrl { get; set; }
        public bool IsJOfTheWeek { get; set; }
        public int JQuantityOnHand { get; set; }

    }
}
