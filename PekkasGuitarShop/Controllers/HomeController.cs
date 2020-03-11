using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PekkasGuitarShop.Models;
using PekkasGuitarShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PekkasGuitarShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGuitarRepository _guitarRepository;

        public HomeController(IGuitarRepository guitarRepository)
        {
            _guitarRepository = guitarRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                OffersOfTheWeek = _guitarRepository.OffersOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
