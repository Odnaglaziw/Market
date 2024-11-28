namespace App
{
    partial class Login
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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            PasswordBox = new TextBox();
            label1 = new Label();
            LoginBox = new TextBox();
            Reglabel = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(235, 247);
            button1.Name = "button1";
            button1.Size = new Size(326, 53);
            button1.TabIndex = 14;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 318);
            label3.Name = "label3";
            label3.Size = new Size(289, 40);
            label3.TabIndex = 13;
            label3.Text = "Зарегистрироваться";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 152);
            label2.Name = "label2";
            label2.Size = new Size(118, 40);
            label2.TabIndex = 12;
            label2.Text = "Пароль";
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(44, 44, 44);
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.ForeColor = SystemColors.Control;
            PasswordBox.Location = new Point(306, 152);
            PasswordBox.MinimumSize = new Size(184, 39);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(184, 39);
            PasswordBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 109);
            label1.Name = "label1";
            label1.Size = new Size(99, 40);
            label1.TabIndex = 10;
            label1.Text = "Логин";
            // 
            // LoginBox
            // 
            LoginBox.BackColor = Color.FromArgb(44, 44, 44);
            LoginBox.BorderStyle = BorderStyle.None;
            LoginBox.ForeColor = SystemColors.Control;
            LoginBox.Location = new Point(306, 107);
            LoginBox.MaximumSize = new Size(300, 39);
            LoginBox.MinimumSize = new Size(184, 39);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(184, 39);
            LoginBox.TabIndex = 9;
            // 
            // Reglabel
            // 
            Reglabel.AutoSize = true;
            Reglabel.Location = new Point(343, 49);
            Reglabel.Name = "Reglabel";
            Reglabel.Size = new Size(84, 40);
            Reglabel.TabIndex = 8;
            Reglabel.Text = "Вход";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox1.Location = new Point(306, 197);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(180, 44);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Запомнить";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(800, 412);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordBox);
            Controls.Add(label1);
            Controls.Add(LoginBox);
            Controls.Add(Reglabel);
            Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox PasswordBox;
        private Label label1;
        private TextBox LoginBox;
        private Label Reglabel;
        private CheckBox checkBox1;
    }
}