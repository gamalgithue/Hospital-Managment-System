using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.Logging;

namespace PM_WinAp
{
    public partial class register : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-N52OIOQ\MSSQLSERVER03;Initial Catalog=loginDB;Integrated Security=True");

        public register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into register values ('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtAge.Text + "','" + txtNumber.Text + "','" + comboBox1.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registered Successfully!");
            cn.Close();
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = null;
            txtPassword.Text = null;
            txtAge.Text = null;
            txtNumber.Text = null;
            comboBox1.Text = null;
        }

        private void lbl_singup_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form frm = new login_form();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
