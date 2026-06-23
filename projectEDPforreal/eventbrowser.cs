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
    public partial class eventbrowser : Form
    {
        int userId;
        private List<Image> eventImages = new List<Image>
    {
        Properties.Resources.OIP_4,
        Properties.Resources.OIP_5,
        Properties.Resources.OIP_7,
        Properties.Resources.OIP_8,
        Properties.Resources.OIP_9
    };
        public eventbrowser(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            grpResults.Controls.Clear();

            string keyword = searchbox.Text;

            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
          Integrated Security=True";

            string query =
                "SELECT concert_id, concert_name FROM Concert WHERE concert_name LIKE @keyword";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                int y = 20;

                while (reader.Read())
                {
                    Button btn = new Button();

                    btn.Text = reader["concert_name"].ToString();
                    btn.Tag = reader["concert_id"];

                    btn.Width = 250;
                    btn.Height = 50;

                    btn.Location = new Point(20, y);

                    btn.Click += ConcertButton_Click;

                    grpResults.Controls.Add(btn);

                    y += 60;
                }
            }
        }

        private void ConcertButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int concertID = Convert.ToInt32(clickedButton.Tag);
            eventdetail form = new eventdetail(concertID, eventImages[(concertID - 1)], userId);
            form.Show();
            this.Hide();
        }
    }
}
