using Microsoft.EntityFrameworkCore;
using Models.Abstractions;
using Models.Models;

namespace DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MarketContext _context;

        public OrderRepository(MarketContext context)
        {
            _context = context;
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public Order GetOrder(int orderId)
        {
            return _context.Orders.Include(o => o.Items).ThenInclude(i => i.Product).FirstOrDefault(o => o.OrderId == orderId);
        }

        public List<Order> GetUserOrders(int userId)
        {
            return _context.Orders.Where(o => o.UserId == userId).ToList();
        }
    }
}
