namespace PM_WinAp
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            lbl_username = new Label();
            lbl_password = new Label();
            label3 = new Label();
            lbl_clear = new Label();
            pictureBox1 = new PictureBox();
            lbl_NoAccount = new Label();
            lbl_singup = new Label();
            label1 = new Label();
            txtUserNameLogin = new TextBox();
            txtPasswordLogin = new TextBox();
            btnLogin = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.LightGray;
            lbl_username.Location = new Point(259, 215);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(123, 27);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "USERNAME";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.LightGray;
            lbl_password.Location = new Point(259, 260);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(126, 27);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(326, 124);
            label3.Name = "label3";
            label3.Size = new Size(135, 46);
            label3.TabIndex = 3;
            label3.Text = "LOGIN!";
            label3.Click += label3_Click;
            // 
            // lbl_clear
            // 
            lbl_clear.AutoSize = true;
            lbl_clear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_clear.ForeColor = Color.Gainsboro;
            lbl_clear.Location = new Point(369, 426);
            lbl_clear.Name = "lbl_clear";
            lbl_clear.Size = new Size(68, 31);
            lbl_clear.TabIndex = 8;
            lbl_clear.Text = "Clear";
            lbl_clear.Click += lbl_clear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 574);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbl_NoAccount
            // 
            lbl_NoAccount.AutoSize = true;
            lbl_NoAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NoAccount.ForeColor = Color.WhiteSmoke;
            lbl_NoAccount.Location = new Point(283, 545);
            lbl_NoAccount.Name = "lbl_NoAccount";
            lbl_NoAccount.Size = new Size(178, 20);
            lbl_NoAccount.TabIndex = 12;
            lbl_NoAccount.Text = "Do not have an account ";
            // 
            // lbl_singup
            // 
            lbl_singup.AutoSize = true;
            lbl_singup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_singup.ForeColor = Color.Firebrick;
            lbl_singup.Location = new Point(457, 545);
            lbl_singup.Name = "lbl_singup";
            lbl_singup.Size = new Size(65, 20);
            lbl_singup.TabIndex = 13;
            lbl_singup.Text = "SIGNUP";
            lbl_singup.Click += lbl_singup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(337, 525);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 16;
            label1.Text = "forget password";
            // 
            // txtUserNameLogin
            // 
            txtUserNameLogin.Location = new Point(397, 215);
            txtUserNameLogin.Name = "txtUserNameLogin";
            txtUserNameLogin.Size = new Size(125, 27);
            txtUserNameLogin.TabIndex = 17;
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.Location = new Point(397, 260);
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.Size = new Size(125, 27);
            txtPasswordLogin.TabIndex = 18;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Teal;
            btnLogin.Location = new Point(326, 361);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 48);
            btnLogin.TabIndex = 45;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(509, 12);
            button1.Name = "button1";
            button1.Size = new Size(29, 31);
            button1.TabIndex = 46;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(550, 574);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(txtPasswordLogin);
            Controls.Add(txtUserNameLogin);
            Controls.Add(label1);
            Controls.Add(lbl_singup);
            Controls.Add(lbl_NoAccount);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_clear);
            Controls.Add(label3);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "lOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_username;
        private Label lbl_password;
        private Label label3;
        private Label lbl_clear;
        private PictureBox pictureBox1;
        private Label lbl_NoAccount;
        private Label lbl_singup;
        private Label label1;
        private TextBox txtUserNameLogin;
        private TextBox txtPasswordLogin;
        private Button btnLogin;
        private Button button1;
    }
}