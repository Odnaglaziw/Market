using DataAccess;

namespace App
{
    public partial class Form1 : Form
    {
        static MarketContext MarketContext = new MarketContext();
        public Form1()
        {
            InitializeComponent();
            if (MarketContext.Connection) MessageBox.Show($"Подключено");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
