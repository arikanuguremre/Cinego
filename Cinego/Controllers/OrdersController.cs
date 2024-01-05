#nullable disable
using Cinego.Data.Services;
using Cinego.Data.ViewModel;
using Cinego.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cinego.Controllers
{
   
    public class OrdersController : Controller
    {
       private readonly IMoviesService _moviesService;
        private readonly Cart _cart;
        

        public OrdersController(IMoviesService moviesService, Cart cart)
        {
            _moviesService = moviesService;
            _cart = cart;
          
        }

     

        public IActionResult Cart()
        {
            var items = _cart.GetCartItems();
            _cart.CartItems = items;

            var response = new CartViewModel()
            {
                Cart = _cart,
                CartTotal = _cart.GetCartTotal()
            };

            return View(response);
        }

        public async Task<RedirectToActionResult> AddToCart(int id)
        {
            var item = await _moviesService.GetByIdAsync(id);
            if (item != null)
            {
                _cart.AddItemToCart(item);
                TempData["Success"] = item.Name + " added to your cart.";
            }
            return RedirectToAction(nameof(Cart));
        }

        public async Task<RedirectToActionResult> RemoveItemFromCart(int id)
        {
            var item = await _moviesService.GetByIdAsync(id);
            if (item != null)
            {
                _cart.RemoveItemFromCart(item);
                TempData["Error"] = item.Name + " removed from your cart.";
            }
            return RedirectToAction(nameof(Cart));
        }
    }
}
