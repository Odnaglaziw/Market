using Microsoft.EntityFrameworkCore;
using Models.Abstractions;
using Models.Models;

namespace DataAccess.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly MarketContext _context;

        public CartRepository(MarketContext context)
        {
            _context = context;
        }

        public void AddToCart(Cart cart)
        {
            var existingCart = _context.Carts.FirstOrDefault(c => c.UserId == cart.UserId && c.ProductId == cart.ProductId);
            if (existingCart != null)
            {
                existingCart.Quantity += cart.Quantity;
            }
            else
            {
                _context.Carts.Add(cart);
            }
            _context.SaveChanges();
        }

        public List<Cart> GetUserCart(int userId)
        {
            return _context.Carts.Include(c => c.Product).Where(c => c.UserId == userId).ToList();
        }

        public void ClearCart(int userId)
        {
            var userCart = _context.Carts.Where(c => c.UserId == userId);
            _context.Carts.RemoveRange(userCart);
            _context.SaveChanges();
        }
    }

}
