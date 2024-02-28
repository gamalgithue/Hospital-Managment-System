using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fa
{
	public partial class Form1 : Form
	{
		SqlConnection cn = new SqlConnection("Data Source=KARIM;Initial Catalog=HospitalSystem;Integrated Security=True");
		public int StudentId {  get; set; }
		public Form1()
		{
			InitializeComponent();
			cn.Open();

			SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [id]   FROM [HospitalSystem].[dbo].[DoctorsTbl] ", cn);

			SqlDataReader sdr = cmd.ExecuteReader();
			sdr.Read();
		


			foreach (var item in sdr)
			{
				DoctorCM.Items.Add(sdr["id"]);
			}

			cn.Close();



			cn.Open();

		   SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM [HospitalSystem].[dbo].[PatientTbl] ", cn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			cn.Close();

		}
	

		private void label6_Click(object sender, EventArgs e)
		{


		}

		private void Addbtn_Click(object sender, EventArgs e)
		{
			cn.Open();
			SqlCommand cmd = new SqlCommand("insert into [dbo].[PatientTbl] values ('"+ txt_name.Text + "','"+ GenderCM.Text + "','"+txt_age.Text+"','"+ txt_Contact.Text + "','"+ BloodCM.Text + "','"+ txt_address.Text + "','"+ SymptomCM.Text + "','"+DoctorCM.Text+"')",cn);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Saved Successfully");
			txt_name.Text = GenderCM.Text = txt_Contact.Text = txt_age.Text = BloodCM.Text = txt_address.Text = SymptomCM.Text = null;
			SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM [HospitalSystem].[dbo].[PatientTbl] ", cn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			cn.Close();
		}

		private void DoctorCM_SelectedIndexChanged(object sender, EventArgs e)
		{
			

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Editbtn_Click(object sender, EventArgs e)
		{
			//cn.Open();
			//SqlCommand cmd = new SqlCommand("SELECT *  FROM [HospitalSystem].[dbo].[PatientTbl] ", cn);
			  cn.Open();
			SqlCommand cmd = new SqlCommand("  Update [dbo].[PatientTbl]  set Name = '"+txt_name.Text+"', Gender = '"+GenderCM.Text+"', Age = '"+txt_age.Text+"', Contact = '"+txt_Contact.Text+"', Blood = '"+BloodCM.Text+"', Address = '"+txt_address.Text+"', Symptom = '"+SymptomCM.Text+"', DoctorId = '"+ DoctorCM.Text + "' where id = '"+StudentId+"' ", cn);

			cmd.ExecuteNonQuery();
			MessageBox.Show("Updated Successfully!");

            txt_name.Text = GenderCM.Text = txt_Contact.Text = txt_address.Text = txt_age.Text = SymptomCM.Text = null;
            SqlCommand cmd1 = new SqlCommand("select * from [dbo].[PatientTbl] ", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
		
		}

		private void Deletebtn_Click(object sender, EventArgs e)
		{

			cn.Open();
			SqlCommand cmd = new SqlCommand("  Delete  from  [dbo].[PatientTbl] where id ='"+ StudentId + "'", cn);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Deleted Successfully");
			txt_name.Text = GenderCM.Text = txt_Contact.Text = txt_address.Text = txt_age.Text = SymptomCM.Text = null;
			SqlCommand cmd1 = new SqlCommand("select * from [dbo].[PatientTbl] ", cn);
			SqlDataAdapter da = new SqlDataAdapter(cmd1);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			cn.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindex = e.RowIndex;

			StudentId = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
			txt_name.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
			GenderCM.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
			txt_age.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
			txt_Contact.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
			BloodCM.Text  = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
			txt_address.Text = dataGridView1.Rows[rowindex].Cells[6].Value.ToString();
			SymptomCM.Text = dataGridView1.Rows[rowindex].Cells[7].Value.ToString();
			DoctorCM.Text = dataGridView1.Rows[rowindex].Cells[8].Value.ToString();


		}

		
	}
}
