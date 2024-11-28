namespace App
{
    partial class SignIn
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
            Reglabel = new Label();
            LoginBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PasswordBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // Reglabel
            // 
            Reglabel.AutoSize = true;
            Reglabel.Location = new Point(306, 53);
            Reglabel.Name = "Reglabel";
            Reglabel.Size = new Size(184, 40);
            Reglabel.TabIndex = 0;
            Reglabel.Text = "Регистрация";
            // 
            // LoginBox
            // 
            LoginBox.BackColor = Color.FromArgb(44, 44, 44);
            LoginBox.BorderStyle = BorderStyle.None;
            LoginBox.ForeColor = SystemColors.Control;
            LoginBox.Location = new Point(306, 109);
            LoginBox.MaximumSize = new Size(300, 39);
            LoginBox.MinimumSize = new Size(184, 39);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(184, 39);
            LoginBox.TabIndex = 1;
            LoginBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 109);
            label1.Name = "label1";
            label1.Size = new Size(99, 40);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 154);
            label2.Name = "label2";
            label2.Size = new Size(118, 40);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(44, 44, 44);
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.ForeColor = SystemColors.Control;
            PasswordBox.Location = new Point(306, 154);
            PasswordBox.MinimumSize = new Size(184, 39);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(184, 39);
            PasswordBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 319);
            label3.Name = "label3";
            label3.Size = new Size(247, 40);
            label3.TabIndex = 5;
            label3.Text = "Уже есть аккаунт";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(235, 249);
            button1.Name = "button1";
            button1.Size = new Size(326, 53);
            button1.TabIndex = 6;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.ImageAlign = ContentAlignment.MiddleLeft;
            checkBox1.Location = new Point(306, 199);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(169, 44);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Продавец";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SignIn
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
            Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignIn";
            Text = "SignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Reglabel;
        private TextBox LoginBox;
        private Label label1;
        private Label label2;
        private TextBox PasswordBox;
        private Label label3;
        private Button button1;
        private CheckBox checkBox1;
    }
}