using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GearShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GearShop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}