using GearShop.Models;
using GearShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GearShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJerseyRepository _jerseyRepository;
        private readonly IPantRepository _pantRepository;
        private readonly IHelmetRepository _helmetRepository;

        public HomeController(IJerseyRepository jerseyRepository, IPantRepository pantRepository, IHelmetRepository helmetRepository)
        {
            _jerseyRepository = jerseyRepository;
            _pantRepository = pantRepository;
            _helmetRepository = helmetRepository;
        }


        // GET: /<controller>/
        public ActionResult Index()
        {
            var jerseys = _jerseyRepository.GetAllJerseys().OrderBy(j => j.JBrand);
            var pants = _pantRepository.GetAllPants().OrderBy(p => p.PBrand);
            var helmets = _helmetRepository.GetAllHelmets().OrderBy(h => h.HBrand);
            var homeViewModel = new HomeViewModel()
            {
                Title = "All your Gear Needs",
                Jerseys = jerseys.ToList(),
                Pants = pants.ToList(),
                Helmets = helmets.ToList()
            };

            return View(homeViewModel);
        }
        public IActionResult JDetails(int id)
        {
            var jersey = _jerseyRepository.GetJerseyById(id);
            if (jersey == null)
                return NotFound();

            return View(jersey);
        }

        public IActionResult PDetails(int id)
        {
            var pant = _pantRepository.GetPantById(id);
            if (pant == null)
                return NotFound();
            return View(pant);
        }

        public IActionResult HDetails(int id)
        {
            var helmet = _helmetRepository.GetHelmetById(id);
            if (helmet == null)
                return NotFound();
            return View(helmet);
        }



    }



}
