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
    public class GuitarController : Controller
    {
        private readonly IGuitarRepository _guitarRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GuitarController(IGuitarRepository guitarRepository, ICategoryRepository categoryRepository)
        {
            _guitarRepository = guitarRepository;
            _categoryRepository = categoryRepository;
        }
        /*
        public ViewResult List()
        {
            GuitarsListViewModel guitarsListViewModel = new GuitarsListViewModel();
            guitarsListViewModel.Guitars = _guitarRepository.AllGuitars;

            guitarsListViewModel.CurrentCategory = "Guitars";
            return View(guitarsListViewModel);
        }
        */

        public ViewResult List(string category)
        {
            IEnumerable<Guitar> guitars;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                guitars = _guitarRepository.AllGuitars.OrderBy(p => p.GuitarId);
                currentCategory = "All guitars";
            }
            else
            {
                guitars = _guitarRepository.AllGuitars.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.GuitarId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new GuitarsListViewModel
            {
                Guitars = guitars,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var guitar = _guitarRepository.GetGuitarById(id);
            if (guitar == null)
                return NotFound();
            return View(guitar);
        }
    }
}
