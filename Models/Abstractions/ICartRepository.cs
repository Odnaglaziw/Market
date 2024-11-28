using Models.Models;

namespace Models.Abstractions
{
    public interface ICartRepository
    {
        void AddToCart(Cart cart);
        void ClearCart(int userId);
        List<Cart> GetUserCart(int userId);
    }

}
