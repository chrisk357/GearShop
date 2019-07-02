using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GearShop.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}
