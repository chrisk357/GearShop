using GearShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Jersey> Jerseys { get; set; }
        public List<Pant> Pants { get; set; }
    }
}
