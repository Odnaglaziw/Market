namespace App
{
    partial class ProductInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Image = new PictureBox();
            Namelbl = new Label();
            Pricelbl = new Label();
            Ratinglbl = new Label();
            Reviews = new ListBox();
            Descriptionlbl = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Image
            // 
            Image.Location = new Point(12, 12);
            Image.Name = "Image";
            Image.Size = new Size(200, 200);
            Image.TabIndex = 0;
            Image.TabStop = false;
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Location = new Point(12, 215);
            Namelbl.MaximumSize = new Size(200, 40);
            Namelbl.MinimumSize = new Size(200, 40);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(200, 40);
            Namelbl.TabIndex = 1;
            Namelbl.Text = "label1";
            // 
            // Pricelbl
            // 
            Pricelbl.AutoSize = true;
            Pricelbl.Location = new Point(12, 270);
            Pricelbl.MaximumSize = new Size(200, 40);
            Pricelbl.MinimumSize = new Size(200, 40);
            Pricelbl.Name = "Pricelbl";
            Pricelbl.Size = new Size(200, 40);
            Pricelbl.TabIndex = 2;
            Pricelbl.Text = "label1";
            // 
            // Ratinglbl
            // 
            Ratinglbl.AutoSize = true;
            Ratinglbl.Location = new Point(12, 345);
            Ratinglbl.Name = "Ratinglbl";
            Ratinglbl.Size = new Size(92, 40);
            Ratinglbl.TabIndex = 3;
            Ratinglbl.Text = "label1";
            // 
            // Reviews
            // 
            Reviews.FormattingEnabled = true;
            Reviews.ItemHeight = 40;
            Reviews.Location = new Point(218, 215);
            Reviews.Name = "Reviews";
            Reviews.Size = new Size(570, 124);
            Reviews.TabIndex = 4;
            // 
            // Descriptionlbl
            // 
            Descriptionlbl.AutoSize = true;
            Descriptionlbl.Location = new Point(254, 12);
            Descriptionlbl.MaximumSize = new Size(500, 200);
            Descriptionlbl.MinimumSize = new Size(500, 200);
            Descriptionlbl.Name = "Descriptionlbl";
            Descriptionlbl.Size = new Size(500, 200);
            Descriptionlbl.TabIndex = 5;
            Descriptionlbl.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 46);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(618, 345);
            button1.Name = "button1";
            button1.Size = new Size(170, 46);
            button1.TabIndex = 7;
            button1.Text = "Отправить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(167, 346);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 46);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ProductInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(800, 398);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Descriptionlbl);
            Controls.Add(Reviews);
            Controls.Add(Ratinglbl);
            Controls.Add(Pricelbl);
            Controls.Add(Namelbl);
            Controls.Add(Image);
            Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductInfo";
            Text = "ProductInfo";
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Image;
        private Label Namelbl;
        private Label Pricelbl;
        private Label Ratinglbl;
        private ListBox Reviews;
        private Label Descriptionlbl;
        private TextBox textBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
    }
}