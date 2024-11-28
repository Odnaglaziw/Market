using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {
        public Product(int id, string name, string description, double price, string imageUrl, int sellerId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            SellerId = sellerId;
        }
        public Product()
        {
            
        }
        [Key]
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public double Price { get; }
        public string ImageUrl { get; }
        public int SellerId { get; set; }
        public User Seller { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
