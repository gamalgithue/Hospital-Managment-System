namespace fa
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Deletebtn = new System.Windows.Forms.Button();
			this.Editbtn = new System.Windows.Forms.Button();
			this.Addbtn = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_address = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_Contact = new System.Windows.Forms.TextBox();
			this.txt_age = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.GenderCM = new System.Windows.Forms.ComboBox();
			this.BloodCM = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.DoctorCM = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label10 = new System.Windows.Forms.Label();
			this.SymptomCM = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(1154, 766);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(83, 45);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 80;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(728, 197);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(543, 485);
			this.dataGridView1.TabIndex = 79;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Deletebtn
			// 
			this.Deletebtn.BackColor = System.Drawing.Color.Red;
			this.Deletebtn.FlatAppearance.BorderSize = 0;
			this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Deletebtn.ForeColor = System.Drawing.Color.White;
			this.Deletebtn.Location = new System.Drawing.Point(34, 744);
			this.Deletebtn.Name = "Deletebtn";
			this.Deletebtn.Size = new System.Drawing.Size(315, 45);
			this.Deletebtn.TabIndex = 78;
			this.Deletebtn.Text = "Delete";
			this.Deletebtn.UseVisualStyleBackColor = false;
			this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
			// 
			// Editbtn
			// 
			this.Editbtn.BackColor = System.Drawing.Color.LightSeaGreen;
			this.Editbtn.FlatAppearance.BorderSize = 0;
			this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Editbtn.ForeColor = System.Drawing.Color.White;
			this.Editbtn.Location = new System.Drawing.Point(451, 744);
			this.Editbtn.Name = "Editbtn";
			this.Editbtn.Size = new System.Drawing.Size(136, 45);
			this.Editbtn.TabIndex = 77;
			this.Editbtn.Text = "Edit";
			this.Editbtn.UseVisualStyleBackColor = false;
			this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
			// 
			// Addbtn
			// 
			this.Addbtn.BackColor = System.Drawing.Color.Teal;
			this.Addbtn.FlatAppearance.BorderSize = 0;
			this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Addbtn.ForeColor = System.Drawing.Color.White;
			this.Addbtn.Location = new System.Drawing.Point(199, 612);
			this.Addbtn.Name = "Addbtn";
			this.Addbtn.Size = new System.Drawing.Size(150, 45);
			this.Addbtn.TabIndex = 76;
			this.Addbtn.Text = "Save";
			this.Addbtn.UseVisualStyleBackColor = false;
			this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label7.Location = new System.Drawing.Point(169, 447);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 23);
			this.label7.TabIndex = 75;
			this.label7.Text = "Address";
			// 
			// txt_address
			// 
			this.txt_address.ForeColor = System.Drawing.Color.Teal;
			this.txt_address.Location = new System.Drawing.Point(20, 491);
			this.txt_address.Margin = new System.Windows.Forms.Padding(5);
			this.txt_address.Multiline = true;
			this.txt_address.Name = "txt_address";
			this.txt_address.Size = new System.Drawing.Size(494, 89);
			this.txt_address.TabIndex = 74;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label6.Location = new System.Drawing.Point(295, 259);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 73;
			this.label6.Text = "Contact:";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// txt_Contact
			// 
			this.txt_Contact.ForeColor = System.Drawing.Color.Teal;
			this.txt_Contact.Location = new System.Drawing.Point(288, 303);
			this.txt_Contact.Margin = new System.Windows.Forms.Padding(5);
			this.txt_Contact.Multiline = true;
			this.txt_Contact.Name = "txt_Contact";
			this.txt_Contact.Size = new System.Drawing.Size(261, 33);
			this.txt_Contact.TabIndex = 72;
			// 
			// txt_age
			// 
			this.txt_age.ForeColor = System.Drawing.Color.Teal;
			this.txt_age.Location = new System.Drawing.Point(164, 303);
			this.txt_age.Margin = new System.Windows.Forms.Padding(5);
			this.txt_age.Multiline = true;
			this.txt_age.Name = "txt_age";
			this.txt_age.Size = new System.Drawing.Size(89, 30);
			this.txt_age.TabIndex = 71;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label5.Location = new System.Drawing.Point(169, 259);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 23);
			this.label5.TabIndex = 69;
			this.label5.Text = "Age";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label4.Location = new System.Drawing.Point(16, 259);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 68;
			this.label4.Text = "Gender";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label3.Location = new System.Drawing.Point(21, 151);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 23);
			this.label3.TabIndex = 67;
			this.label3.Text = "Name";
			// 
			// txt_name
			// 
			this.txt_name.ForeColor = System.Drawing.Color.Teal;
			this.txt_name.Location = new System.Drawing.Point(20, 199);
			this.txt_name.Margin = new System.Windows.Forms.Padding(5);
			this.txt_name.Multiline = true;
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(261, 29);
			this.txt_name.TabIndex = 66;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkCyan;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1312, 127);
			this.panel1.TabIndex = 65;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(509, 81);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 46);
			this.label2.TabIndex = 1;
			this.label2.Text = "Patient";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(126, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(980, 67);
			this.label1.TabIndex = 0;
			this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
			// 
			// GenderCM
			// 
			this.GenderCM.FormattingEnabled = true;
			this.GenderCM.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.GenderCM.Location = new System.Drawing.Point(20, 303);
			this.GenderCM.Name = "GenderCM";
			this.GenderCM.Size = new System.Drawing.Size(121, 31);
			this.GenderCM.TabIndex = 81;
			// 
			// BloodCM
			// 
			this.BloodCM.FormattingEnabled = true;
			this.BloodCM.Items.AddRange(new object[] {
            " A+\t",
            " A-",
            " B+\t",
            " B-",
            " AB+\t",
            " AB-",
            " O+\t",
            " O-"});
			this.BloodCM.Location = new System.Drawing.Point(20, 400);
			this.BloodCM.Name = "BloodCM";
			this.BloodCM.Size = new System.Drawing.Size(121, 31);
			this.BloodCM.TabIndex = 82;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label8.Location = new System.Drawing.Point(21, 364);
			this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 23);
			this.label8.TabIndex = 83;
			this.label8.Text = "Blood:";
			// 
			// DoctorCM
			// 
			this.DoctorCM.FormattingEnabled = true;
			this.DoctorCM.Location = new System.Drawing.Point(272, 400);
			this.DoctorCM.Name = "DoctorCM";
			this.DoctorCM.Size = new System.Drawing.Size(121, 31);
			this.DoctorCM.TabIndex = 84;
			this.DoctorCM.SelectedIndexChanged += new System.EventHandler(this.DoctorCM_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label9.Location = new System.Drawing.Point(268, 364);
			this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 23);
			this.label9.TabIndex = 85;
			this.label9.Text = "Doctor:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label10.Location = new System.Drawing.Point(306, 162);
			this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 23);
			this.label10.TabIndex = 86;
			this.label10.Text = "Symptom";
			// 
			// SymptomCM
			// 
			this.SymptomCM.FormattingEnabled = true;
			this.SymptomCM.Items.AddRange(new object[] {
            "Eye irretation",
            "Runy Nose",
            "Stuffy Nose",
            "Sneezing",
            "Cough",
            "Other"});
			this.SymptomCM.Location = new System.Drawing.Point(310, 197);
			this.SymptomCM.Name = "SymptomCM";
			this.SymptomCM.Size = new System.Drawing.Size(214, 31);
			this.SymptomCM.TabIndex = 87;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1312, 859);
			this.Controls.Add(this.SymptomCM);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.DoctorCM);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.BloodCM);
			this.Controls.Add(this.GenderCM);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Deletebtn);
			this.Controls.Add(this.Editbtn);
			this.Controls.Add(this.Addbtn);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_address);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_Contact);
			this.Controls.Add(this.txt_age);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Deletebtn;
		private System.Windows.Forms.Button Editbtn;
		private System.Windows.Forms.Button Addbtn;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_address;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_Contact;
		private System.Windows.Forms.TextBox txt_age;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox GenderCM;
		private System.Windows.Forms.ComboBox BloodCM;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox DoctorCM;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox SymptomCM;
	}
}

