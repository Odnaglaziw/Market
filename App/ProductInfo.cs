using DataAccess.Repositories;
using Models.Models;

namespace App
{
    public partial class ProductInfo : Form
    {
        List<Review> reviews = new List<Review>();
        ReviewRepository repository;
        Product _product;
        public ProductInfo(Product product)
        {
            _product = product;
            repository = new ReviewRepository(new DataAccess.MarketContext());
            InitializeComponent();
            Namelbl.Text = product.Name;
            Pricelbl.Text = product.Price.ToString()+" p";
            LoadImageAsync(product.ImageUrl);
            Descriptionlbl.Text = product.Description;
            LoadReviewsAsync(product.Id);
        }
        private async void LoadReviewsAsync(int productId)
        {
            Reviews.Items.Clear();
            reviews = await repository.GetByProductIdAsync(productId);
            Ratinglbl.Text = "0*";
            if (reviews.Count > 0)
                Ratinglbl.Text = ((double)reviews.Sum(r => r.Rating) / reviews.Count).ToString("F2") + "*";
            foreach (var review in reviews)
            {
                Reviews.Items.Add($"{review.Rating}*|{review.User.Name}: {review.Comment}");
            }
        }
        private async void LoadImageAsync(string imageUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >= 10)
            await repository.AddAsync(new Review()
            {
                UserId = Program.user.Id,
                ProductId = _product.Id,
                Comment = textBox1.Text,
                CreatedDate = DateTime.UtcNow,
                Rating = (int)numericUpDown1.Value,
            });
            LoadReviewsAsync(_product.Id);
        }
    }
}
