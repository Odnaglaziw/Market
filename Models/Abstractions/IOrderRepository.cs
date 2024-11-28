using Models.Models;

namespace Models.Abstractions
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        Order GetOrder(int orderId);
        List<Order> GetUserOrders(int userId);
    }

}
