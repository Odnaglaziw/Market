using System.ComponentModel.DataAnnotations;

namespace Models.Models
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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int SellerId { get; set; }
        public User Seller { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
