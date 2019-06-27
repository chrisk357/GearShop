using GearShop.Models;
using System.Collections.Generic;

namespace GearShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Jersey> Jerseys { get; set; }
        public List<Pant> Pants { get; set; }
    }
}
