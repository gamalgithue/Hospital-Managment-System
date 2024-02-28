using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;




namespace employee
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=KH;Initial Catalog=employeesDB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("delete from employee_data where id = '"+text_ID.Text+"'", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted successfully");
            text_ID.Text = null;
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into employee_data values('"+text_NM.Text+"','"+text_AGE.Text+"','"+text_PH.Text+"' ,'"+text_DM.Text+"','"+text_SY.Text+"')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("added successfully");
            text_NM.Text=text_AGE.Text=text_PH.Text=text_SY.Text= text_DM.Text = null;
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from employee_data where id = '" + textBox1.Text + "'", cn);
            SqlDataReader sdr=cmd.ExecuteReader();
            if (sdr.HasRows == true)
            {
                sdr.Read();
                textBox2.Text = sdr["name"].ToString();
                textBox3.Text = sdr["age"].ToString();
                textBox4.Text = sdr["phone"].ToString();
                textBox5.Text = sdr["department"].ToString();
                textBox6.Text = sdr["salary"].ToString();

            }
            else
                MessageBox.Show("Not exist");
            cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update employee_data set name = '" + textBox2.Text + "', age='"+ textBox3.Text + "', phone='"+ textBox4.Text + "', department='"+ textBox5.Text + "', salary='"+ textBox6.Text + "' where id='"+ textBox1.Text+ "'", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully");
            text_ID.Text = null;
            cn.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}