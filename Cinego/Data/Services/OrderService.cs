using Cinego.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinego.Data.Services
{
    public class OrderService : IOrdersService
    {
        private readonly CinegoDbContext _context;

        public OrderService(CinegoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetOrdersByUserIdAsync(string userId,string userRole)
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Movie).ToListAsync();
            if(userRole != "Admin")
            {
                orders=orders.Where(n=>n.UserId==userId).ToList();
            }
            return orders;
        }

        public async Task StoreOrderAsync(List<CartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };
            await _context.Orders.AddAsync(order);  
            await _context.SaveChangesAsync();  

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    MovieId = item.Movie.Id,
                    OrderId = order.Id,
                    Price = item.Movie.Price,
                };
               await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();

        }
    }
}
