using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GearShop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GearShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJerseyRepository _jerseyRepository;
        private readonly IPantRepository _pantRepository;

        public HomeController(IJerseyRepository jerseyRepository, IPantRepository pantRepository)
        {
            _jerseyRepository = jerseyRepository;
            _pantRepository = pantRepository;
        }
        

        // GET: /<controller>/
        public IActionResult Index()
        {
            var jerseys = _jerseyRepository.GetAllJerseys().OrderBy(j => j.JBrand);
            var pants = _pantRepository.GetAllPants().OrderBy(p => p.PBrand);

            return View();
        }
    }
}
