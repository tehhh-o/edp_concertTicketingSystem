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
    public partial class signup : Form
    {
        SqlConnection con = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=C:\Users\user\source\repos\edp_concertTicketingSystem\projectEDPforreal\Ticket2U.mdf;
      Integrated Security=True");

        public signup()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = false;
            loginPanel.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = true;
            loginPanel.Visible = false;
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=C:\Users\user\source\repos\edp_concertTicketingSystem\projectEDPforreal\Ticket2U.mdf;
      Integrated Security=True"))
                {
                    con.Open();

                    // Get latest user_id
                    string getIdQuery = "SELECT ISNULL(MAX(user_id), 0) + 1 FROM [User]";
                    SqlCommand getIdCmd = new SqlCommand(getIdQuery, con);

                    int newUserId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                    // Insert new user with generated user_id
                    string query = "INSERT INTO [User] (user_id, name, email, password, phone_number, user_type) " +
                                   "VALUES (@user_id, @name, @email, @password, @phone_number, @user_type)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user_id", newUserId);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@phone_number", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@user_type", cmbUserType.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Sign up successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
