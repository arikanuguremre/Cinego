#nullable disable
using Cinego.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cinego.Models
{
    public class Cart
    {
        public CinegoDbContext _context { get; set; }
        public string CartId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public Cart(CinegoDbContext context)
        {
            _context = context;
        }
        public static Cart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<CinegoDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new Cart(context) { CartId = cartId };
        }

        public List<CartItem> GetCartItems()
        {
            return CartItems ?? (CartItems = _context.CartItems.Where(n => n.CartId == CartId).Include(n => n.Movie).ToList());

        }
        public double GetCartTotal() => _context.CartItems.Where(n => n.CartId == CartId).Select(n => n.Movie.Price * n.Amount).Sum();
        public void AddItemToCart(Movie movie)
        {
            var CartItem = _context.CartItems.FirstOrDefault(n=>n.Movie.Id == movie.Id && n.CartId==CartId);
            if(CartItem == null)
            {
                CartItem = new CartItem()
                {
                    CartId = CartId,
                    Movie = movie,
                    Amount = 1
                };
                _context.CartItems.Add(CartItem);

            }
            else
            {
                CartItem.Amount++;
            }
            _context.SaveChanges();
        }

        public void RemoveItemFromCart(Movie movie) 
        {
            var CartItem = _context.CartItems.FirstOrDefault(n => n.Movie.Id == movie.Id && n.CartId == CartId);
            if (CartItem != null)
            {
                if(CartItem.Amount > 1) {
                    CartItem.Amount--;
                }
                else
                {
                    _context.CartItems.Remove(CartItem);
                }
            }       
            _context.SaveChanges();
        }





    }
}
