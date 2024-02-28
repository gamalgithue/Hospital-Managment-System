using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class Doctor : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=JOO-PC\MSSQLSERVER2022;Initial Catalog=HospitalSystem;Integrated Security=True;TrustServerCertificate=True");
        public int StudentId { set; get; }
        public Doctor()
        {
            InitializeComponent();
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from DoctorsTbl", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            cn.Open();
           SqlCommand cmd = new SqlCommand("insert into DoctorsTbl values('" + txt_name.Text + " ','  " + txt_yoe.Text + " ','" + txt_age.Text +" ','"+txt_phone.Text+" ','"+txt_address.Text+"')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Successfully!");

            txt_name.Text = txt_yoe.Text = txt_age.Text = txt_phone.Text = txt_address.Text = null;
            SqlCommand cmd1 = new SqlCommand("select * from DoctorsTbl", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {



            
           

            
                  

             cn.Open();
            //SqlCommand cmd2 = new SqlCommand("select * from DoctorsTbl", cn);

            //SqlDataReader sdr = cmd2.ExecuteReader();
            //sdr.Read();
            //string id = sdr["id"].ToString();




            SqlCommand cmd = new SqlCommand("delete  from DoctorsTbl where id = "+StudentId+" ", cn);
            //cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
            //cmd.Parameters.AddWithValue("@ID", this.StudentId);
            MessageBox.Show("Deleted Successfully!");
                txt_name.Text = txt_yoe.Text = txt_age.Text = txt_phone.Text = txt_address.Text = null;
                SqlCommand cmd1 = new SqlCommand("select * from DoctorsTbl", cn);
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
                txt_yoe.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                txt_age.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                txt_phone.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                txt_address.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();

       

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update DoctorsTbl set DocName = '"+txt_name.Text+"' , yearsofexprience="+txt_yoe.Text+" , age='"+txt_age.Text +"', contactphone='"+txt_phone.Text +"', address='"+txt_address.Text +"' where id ='"+StudentId+"' ;", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!");

            txt_name.Text = txt_yoe.Text = txt_age.Text = txt_phone.Text = txt_address.Text = null;
            SqlCommand cmd1 = new SqlCommand("select * from DoctorsTbl", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
