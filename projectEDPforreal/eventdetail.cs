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

namespace projectEDPforreal
{
    public partial class eventdetail : Form
    {
        int concertID;
        public eventdetail()
        {
            InitializeComponent();
        }

        public eventdetail(int id)
        {
            InitializeComponent();
            concertID = id;
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
                "SELECT seat_number FROM Seat " +
                "WHERE seat_number LIKE @prefix " +
                "AND seat_status = 'Available'";

            SqlCommand cmd = new SqlCommand(query, conn);

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
    }
}
