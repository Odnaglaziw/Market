namespace Models
{
    public class Review
    {
        public Review(int id, int productId, int userId, int rating, string comment, DateTime createdDate)
        {
            Id = id;
            ProductId = productId;
            UserId = userId;
            Rating = rating;
            Comment = comment;
            CreatedDate = createdDate;
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
