namespace App
{
    partial class Main
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
            panel1 = new Panel();
            PasswordBox = new TextBox();
            EmalBox = new TextBox();
            NameBox = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 66, 66);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(EmalBox);
            panel1.Controls.Add(NameBox);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 412);
            panel1.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(66, 66, 66);
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.ForeColor = SystemColors.Menu;
            PasswordBox.Location = new Point(12, 220);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(182, 39);
            PasswordBox.TabIndex = 9;
            PasswordBox.Text = "********";
            // 
            // EmalBox
            // 
            EmalBox.BackColor = Color.FromArgb(66, 66, 66);
            EmalBox.BorderStyle = BorderStyle.None;
            EmalBox.ForeColor = SystemColors.Menu;
            EmalBox.Location = new Point(12, 116);
            EmalBox.Name = "EmalBox";
            EmalBox.Size = new Size(182, 39);
            EmalBox.TabIndex = 8;
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(66, 66, 66);
            NameBox.BorderStyle = BorderStyle.None;
            NameBox.ForeColor = SystemColors.Menu;
            NameBox.Location = new Point(12, 12);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(182, 39);
            NameBox.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(44, 44, 44);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(12, 347);
            button4.Name = "button4";
            button4.Size = new Size(182, 53);
            button4.TabIndex = 6;
            button4.Text = "Корзина";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(12, 265);
            button3.Name = "button3";
            button3.Size = new Size(182, 53);
            button3.TabIndex = 5;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 161);
            button2.Name = "button2";
            button2.Size = new Size(182, 53);
            button2.TabIndex = 3;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 57);
            button1.Name = "button1";
            button1.Size = new Size(182, 53);
            button1.TabIndex = 1;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 22, 22);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 57);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(582, 39);
            textBox1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(200, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 355);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(800, 412);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox PasswordBox;
        private TextBox EmalBox;
        private TextBox NameBox;
    }
}