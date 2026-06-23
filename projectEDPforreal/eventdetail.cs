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
    public partial class eventdetail : Form
    {
        int userId;
        int concertID;
        Image concertImage;

        public eventdetail(int id, Image img, int userId)
        {
            InitializeComponent();
            concertID = id;
            concertImage = img;
            this.userId = userId;
        }
        private void eventdetail_Load(object sender, EventArgs e)
        {
            LoadConcertData();
        }

        private void LoadConcertData()
        {
            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
                Integrated Security=True";

            string query =
                "SELECT concert_name, concert_details, date " +
                "FROM Concert WHERE concert_id = @id";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", concertID);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblName.Text = reader["concert_name"].ToString();
                    lblLocation.Text = reader["concert_details"].ToString();

                    DateTime date = Convert.ToDateTime(reader["date"]);
                    lblDate.Text = date.ToString("dd MMM yyyy");
                }
            }
            eventPicBox.Image = concertImage;
        }
       
        private void LoadAvailableSeats()
        {
            lstSeats.Items.Clear();

            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
        Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (rowA.Checked)
                    LoadSeats(conn, "V");

                if (rowB.Checked)
                    LoadSeats(conn, "P");

                if (rowC.Checked)
                    LoadSeats(conn, "S");
            }
        }

        private void LoadSeats(SqlConnection conn, string prefix)
        {
            string query =
                "SELECT s.seat_number " +
                "FROM Seat s " +
                "INNER JOIN TicketType tt ON s.ticket_type_id = tt.ticket_type_id " +
                "WHERE tt.concert_id = @concert_id " +
                "AND tt.type_name LIKE @prefix " +
                "AND s.seat_status = 'Available'";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@concert_id", concertID);
            cmd.Parameters.AddWithValue("@prefix", prefix + "%");

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lstSeats.Items.Add(reader["seat_number"].ToString());
            }

            reader.Close();
        }

        private void rowA_CheckedChanged(object sender, EventArgs e)
        {
            LoadAvailableSeats();
        }

        private void rowB_CheckedChanged(object sender, EventArgs e)
        {
            LoadAvailableSeats();
        }

        private void rowC_CheckedChanged(object sender, EventArgs e)
        {
            LoadAvailableSeats();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userId);
            this.Hide();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstSeats.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one seat before proceeding.",
                    "No Seat Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> selectedSeats = new List<string>();
            foreach (var item in lstSeats.SelectedItems)
            {
                selectedSeats.Add(item.ToString());
            }

            checkout checkoutForm = new checkout(concertID, selectedSeats, userId);
            this.Hide();
            checkoutForm.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString =
               @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if bookmark already exists
                string checkQuery =
                    "SELECT COUNT(*) FROM BookMark " +
                    "WHERE user_id = @user_id AND concert_id = @concert_id";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@user_id", userId);
                checkCmd.Parameters.AddWithValue("@concert_id", concertID);

                int existing = (int)checkCmd.ExecuteScalar();

                if (existing > 0)
                {
                    MessageBox.Show("This concert is already bookmarked.",
                        "Already Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Get next bookmark_id
                string maxIdQuery = "SELECT ISNULL(MAX(bookmark_id), 0) + 1 FROM BookMark";
                SqlCommand maxIdCmd = new SqlCommand(maxIdQuery, conn);
                int newBookmarkId = (int)maxIdCmd.ExecuteScalar();

                // Insert bookmark
                string insertQuery =
                    "INSERT INTO BookMark (bookmark_id, user_id, concert_id, saved_date) " +
                    "VALUES (@bookmark_id, @user_id, @concert_id, @saved_date)";

                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@bookmark_id", newBookmarkId);
                insertCmd.Parameters.AddWithValue("@user_id", userId);
                insertCmd.Parameters.AddWithValue("@concert_id", concertID);
                insertCmd.Parameters.AddWithValue("@saved_date", DateTime.Today);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Concert bookmarked successfully!",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
