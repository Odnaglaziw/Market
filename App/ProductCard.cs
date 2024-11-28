using Models.Models;
using System.Reflection;

namespace App
{
    public class ProductCard : UserControl
    {
        private Label NameLabel;
        private Label PriceLabel;
        private Button ViewButton;
        private Button AddToCartButton;
        private Panel CardPanel;
        private PictureBox ProductImage;
        private Button button1;
        private Button button2;
        private Product product;

        public ProductCard(Product product)
        {
            this.product = product;
            InitializeComponent();
            NameLabel.Text = product.Name;
            PriceLabel.Text = $"{product.Price.ToString()} р.";
            LoadImageAsync(product.ImageUrl);
            ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            foreach (Control control in Controls)
            {
                SetDoubleBuffered(control);
            }
        }

        private void InitializeComponent()
        {
            CardPanel = new Panel();
            button2 = new Button();
            ProductImage = new PictureBox();
            button1 = new Button();
            NameLabel = new Label();
            PriceLabel = new Label();
            CardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            SuspendLayout();
            // 
            // CardPanel
            // 
            CardPanel.BorderStyle = BorderStyle.FixedSingle;
            CardPanel.Controls.Add(button2);
            CardPanel.Controls.Add(ProductImage);
            CardPanel.Controls.Add(button1);
            CardPanel.Controls.Add(NameLabel);
            CardPanel.Controls.Add(PriceLabel);
            CardPanel.Location = new Point(10, 10);
            CardPanel.Name = "CardPanel";
            CardPanel.Size = new Size(200, 354);
            CardPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(147, 293);
            button2.Name = "button2";
            button2.Size = new Size(48, 48);
            button2.TabIndex = 2;
            button2.Text = "\U0001f6d2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ProductImage
            // 
            ProductImage.Location = new Point(0, 0);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(200, 200);
            ProductImage.TabIndex = 0;
            ProductImage.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 293);
            button1.Name = "button1";
            button1.Size = new Size(135, 48);
            button1.TabIndex = 1;
            button1.Text = "отзывы";
            button1.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            NameLabel.Location = new Point(10, 205);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(180, 40);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Товар";
            // 
            // PriceLabel
            // 
            PriceLabel.Location = new Point(10, 250);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(180, 40);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "100 р.";
            // 
            // ProductCard
            // 
            BackColor = Color.Transparent;
            Controls.Add(CardPanel);
            Name = "ProductCard";
            Size = new Size(225, 391);
            CardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ResumeLayout(false);
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
                        ProductImage.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }
        private void SetDoubleBuffered(Control control)
        {
            // Используем рефлексию для установки DoubleBuffered
            var propertyInfo = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(control, true);
            }
        }
    }

}
