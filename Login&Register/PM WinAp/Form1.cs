using System.Data.SqlClient;

namespace PM_WinAp
{
    public partial class login_form : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-N52OIOQ\MSSQLSERVER03;Initial Catalog=loginDB;Integrated Security=True");

        public login_form()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserNameLogin.Text == "")
            {
                MessageBox.Show("Please Enter Username");
            }
            else if (txtPasswordLogin.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from register where username ='" + txtUserNameLogin.Text + "' and password = '" + txtPasswordLogin + "'", cn);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows==true)
                {
                    MessageBox.Show("login successfully!");
                }
                else
                {
                    MessageBox.Show("login failed!please enter valid username and password");
                }
                cn.Close();

            }
        }
        private void lbl_singup_Click(object sender, EventArgs e)
        {
            this.Hide();
            register rs = new register();
            rs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_clear_Click(object sender, EventArgs e)
        {
            txtPasswordLogin.Text = null;
            txtUserNameLogin.Text = null;
        }
       /* private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }*/

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }

       
    }
}