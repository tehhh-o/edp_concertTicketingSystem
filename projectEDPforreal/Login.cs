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
      AttachDbFilename=C:\Users\user\source\repos\edp_concertTicketingSystem\projectEDPforreal\Ticket2U.mdf;
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
              AttachDbFilename=C:\Users\user\source\repos\edp_concertTicketingSystem\projectEDPforreal\Ticket2U.mdf;
              Integrated Security=True"))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM [User] WHERE (name = @username OR email = @username) AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@username", txtLoginEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtLoginPassword.Text.Trim());

                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Log In Successful!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Form1 main = new Form1();
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

    }
}
