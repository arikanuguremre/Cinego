using Cinego.Models;

namespace Cinego.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync (List<CartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId,string userRole);
    }
}
