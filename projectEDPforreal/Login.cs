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
using System.Xml.Linq;

namespace projectEDPforreal
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(
      @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
      Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
              Integrated Security=True"))
                {
                    con.Open();

                    string query = "SELECT user_id FROM [User] WHERE (name = @username OR email = @username) AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@username", txtLoginEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtLoginPassword.Text.Trim());

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);
                            MessageBox.Show("Log In Successful!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Form1 main = new Form1(userId);
                            main.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Nama/Emel atau Kata Laluan salah. Sila cuba lagi.", "Ralat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ralat Sistem: " + ex.Message, "Ralat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup Signup = new signup();
            Signup.ShowDialog();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
