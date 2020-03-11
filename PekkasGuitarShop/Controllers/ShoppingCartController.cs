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
    public class ShoppingCartController : Controller
    {

        private readonly IGuitarRepository _guitarRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IGuitarRepository guitarRepository, ShoppingCart shoppingCart)
        {
            _guitarRepository = guitarRepository;
            _shoppingCart = shoppingCart;
        }


        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int guitarId)
        {
            var selectedGuitar = _guitarRepository.AllGuitars.FirstOrDefault(p => p.GuitarId == guitarId);

            if (selectedGuitar != null)
            {
                _shoppingCart.AddToCart(selectedGuitar, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int guitarId)
        {
            var selectedGuitar = _guitarRepository.AllGuitars.FirstOrDefault(p => p.GuitarId == guitarId);

            if (selectedGuitar != null)
            {
                _shoppingCart.RemoveFromCart(selectedGuitar);
            }
            return RedirectToAction("Index");
        }
    }
}
