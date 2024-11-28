
using DataAccess;
using DataAccess.Repositories;
using System.Reflection;
using System.Windows.Forms;

namespace App
{
    public partial class Main : Form
    {
        bool moving = false;
        ProductRepository repository;
        UserRepository userRepository;
        public Main()
        {
            repository = new ProductRepository(new MarketContext());
            userRepository = new UserRepository(new MarketContext());
            InitializeComponent();
            SetDoubleBuffered(flowLayoutPanel1);
            panel1.MouseEnter += (s, e) => { if (!moving) ShowPanel(); };
            panel1.MouseLeave += (s, e) =>
            {
                var onscreen = PointToClient(Cursor.Position);
                bool isOutside = !NameBox.ClientRectangle.WithLocation(NameBox.Location).Contains(onscreen) &&
                     !button1.ClientRectangle.WithLocation(button1.Location).Contains(onscreen) &&
                     !EmalBox.ClientRectangle.WithLocation(EmalBox.Location).Contains(onscreen) &&
                     !button2.ClientRectangle.WithLocation(button2.Location).Contains(onscreen) &&
                     !PasswordBox.ClientRectangle.WithLocation(PasswordBox.Location).Contains(onscreen) &&
                     !button3.ClientRectangle.WithLocation(button3.Location).Contains(onscreen) &&
                     !button4.ClientRectangle.WithLocation(button4.Location).Contains(onscreen);

                if (!moving && isOutside)
                {
                    ClosePanel();
                }
            };
            NameBox.Text = Program.user.Name;
            EmalBox.Text = Program.user.Email;
            LoadProducts();
        }
        private void ShowPanel()
        {
            moving = true;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer() { Interval = 16 };
            timer.Start();
            int startWidth = panel1.Width;
            int targetWidth = 200;
            int distance = targetWidth - startWidth;
            int elapsedTime = 0; // Время с момента начала анимации

            timer.Tick += (s, e) =>
            {
                elapsedTime++;

                // Вычисляем фактор ускорения/замедления (квадратичная функция)
                float easingFactor = (float)(Math.Pow((double)elapsedTime / 50, 2)); // 50 - это максимальное время анимации
                if (easingFactor > 1)
                    easingFactor = 1; // Ограничиваем значение на 1

                // Применяем увеличение или уменьшение ширины
                panel1.Width = startWidth + (int)(distance * easingFactor);

                if (panel1.Width >= targetWidth)
                {
                    timer.Stop();
                    timer.Dispose();
                    moving = false;
                }
            };
        }
        private void ClosePanel()
        {
            moving = true;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer() { Interval = 16 };
            timer.Start();
            int startWidth = panel1.Width;
            int targetWidth = 15;
            int distance = startWidth - targetWidth;
            int elapsedTime = 0; // Время с момента начала анимации

            timer.Tick += (s, e) =>
            {
                elapsedTime++;

                // Вычисляем фактор ускорения/замедления (квадратичная функция)
                float easingFactor = (float)(Math.Pow((double)elapsedTime / 50, 2)); // 50 - это максимальное время анимации
                if (easingFactor > 1)
                    easingFactor = 1; // Ограничиваем значение на 1

                // Применяем уменьшение ширины
                panel1.Width = startWidth - (int)(distance * easingFactor);

                if (panel1.Width <= targetWidth)
                {
                    timer.Stop();
                    timer.Dispose();
                    moving = false;
                }
            };
        }
        private async void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BorderStyle = BorderStyle.None;
            var products = await repository.GetAllAsync();

            foreach (var product in products)
            {
                var productCard = new ProductCard(product)
                {
                    Size = new Size(220, 400)
                };

                flowLayoutPanel1.Controls.Add(productCard);
            }
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

        private async void button1_Click(object sender, EventArgs e)
        {
            Program.user.Name = NameBox.Text;
            await userRepository.UpdateAsync(Program.user);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Program.user.Email = EmalBox.Text;
            await userRepository.UpdateAsync(Program.user);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Program.user.Password = Program.HashPassword(PasswordBox.Text.Trim());
            await userRepository.UpdateAsync(Program.user);
        }
    }
    public static class RectangleExtensions
    {
        public static Rectangle WithLocation(this Rectangle rectangle, Point location)
        {
            return new Rectangle(rectangle.X + location.X, rectangle.Y + location.Y, rectangle.Width, rectangle.Height);
        }
    }
}
