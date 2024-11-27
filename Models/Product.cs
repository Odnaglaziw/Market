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

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public double Price { get; }
        public string ImageUrl { get; }
        public int SellerId { get; set; }
    }
}
