namespace PM_WinAp
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            lbl_singup = new Label();
            lbl_NoAccount = new Label();
            pictureBox1 = new PictureBox();
            lbl_clear = new Label();
            label3 = new Label();
            lbl_password = new Label();
            lbl_username = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            txtNumber = new TextBox();
            txtAge = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_singup
            // 
            lbl_singup.AutoSize = true;
            lbl_singup.Cursor = Cursors.Hand;
            lbl_singup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_singup.ForeColor = Color.Firebrick;
            lbl_singup.Location = new Point(280, 632);
            lbl_singup.Name = "lbl_singup";
            lbl_singup.Size = new Size(56, 20);
            lbl_singup.TabIndex = 27;
            lbl_singup.Text = "LOGIN";
            lbl_singup.Click += lbl_singup_Click;
            // 
            // lbl_NoAccount
            // 
            lbl_NoAccount.AutoSize = true;
            lbl_NoAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NoAccount.ForeColor = Color.WhiteSmoke;
            lbl_NoAccount.Location = new Point(102, 632);
            lbl_NoAccount.Name = "lbl_NoAccount";
            lbl_NoAccount.Size = new Size(184, 20);
            lbl_NoAccount.TabIndex = 26;
            lbl_NoAccount.Text = "Already have an account ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(420, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 699);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // lbl_clear
            // 
            lbl_clear.AutoSize = true;
            lbl_clear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_clear.ForeColor = Color.Gainsboro;
            lbl_clear.Location = new Point(280, 547);
            lbl_clear.Name = "lbl_clear";
            lbl_clear.Size = new Size(68, 31);
            lbl_clear.TabIndex = 23;
            lbl_clear.Text = "Clear";
            lbl_clear.Click += lbl_clear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(32, 59);
            label3.Name = "label3";
            label3.Size = new Size(303, 49);
            label3.TabIndex = 19;
            label3.Text = "RESGITER NOW!";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.LightGray;
            lbl_password.Location = new Point(46, 271);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(126, 27);
            lbl_password.TabIndex = 18;
            lbl_password.Text = "PASSWORD";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.LightGray;
            lbl_username.Location = new Point(46, 223);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(123, 27);
            lbl_username.TabIndex = 17;
            lbl_username.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(86, 366);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 29;
            label2.Text = "AGE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(62, 414);
            label4.Name = "label4";
            label4.Size = new Size(93, 27);
            label4.TabIndex = 31;
            label4.Text = "GENDER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(65, 319);
            label5.Name = "label5";
            label5.Size = new Size(98, 27);
            label5.TabIndex = 33;
            label5.Text = "NUMBER";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(201, 414);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 37;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(201, 322);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(151, 27);
            txtNumber.TabIndex = 39;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(201, 366);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(151, 27);
            txtAge.TabIndex = 41;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(201, 226);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(151, 27);
            txtUsername.TabIndex = 42;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(201, 271);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 27);
            txtPassword.TabIndex = 43;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.Teal;
            btnRegister.Location = new Point(102, 537);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(147, 53);
            btnRegister.TabIndex = 44;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(29, 31);
            button1.TabIndex = 45;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(669, 699);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtAge);
            Controls.Add(txtNumber);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lbl_singup);
            Controls.Add(lbl_NoAccount);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_clear);
            Controls.Add(label3);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "register";
            Text = "register";
            Load += register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_singup;
        private Label lbl_NoAccount;
        private PictureBox pictureBox1;
        private Label lbl_clear;

        private Label label3;
        private Label lbl_password;
        private Label lbl_username;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textbox_username;
        private TextBox textBox3;
        private TextBox txtNumber;
        private TextBox textbox_password;
        private TextBox txtAge;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button button1;
    }
}