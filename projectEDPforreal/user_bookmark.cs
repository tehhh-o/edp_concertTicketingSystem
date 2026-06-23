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
    public partial class user_bookmark : Form
    {
        private int _userId;

        public user_bookmark(int userId)
        {
            InitializeComponent();
            _userId = userId;
            SetupListView();
            LoadBookmarks();
        }

        private void SetupListView()
        {
            lbBookmark.View = View.Details;
            lbBookmark.FullRowSelect = true;
            lbBookmark.GridLines = true;
            lbBookmark.Columns.Clear();

            lbBookmark.Columns.Add("Bookmark ID", 80);
            lbBookmark.Columns.Add("User Name", 90);
            lbBookmark.Columns.Add("Concert ID", 70);
            lbBookmark.Columns.Add("Concert Name", 220);
            lbBookmark.Columns.Add("Saved Date", 120);
        }

        private void user_bookmark_Load(object sender, EventArgs e)
        {
            LoadBookmarks();
        }

        private void LoadBookmarks()
        {
            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
        Integrated Security=True";

            string query = @"
        SELECT b.bookmark_id, b.user_id, u.name, b.concert_id, c.concert_name, b.saved_date
        FROM dbo.BookMark b
        INNER JOIN dbo.[User] u ON b.user_id = u.user_id
        INNER JOIN dbo.Concert c ON b.concert_id = c.concert_id
        WHERE b.user_id = @userId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    lbBookmark.Items.Clear();

                    while (reader.Read())
                    {
                        int bookmarkId = reader.GetInt32(0);
                        decimal userId = reader.GetDecimal(1);
                        string userName = reader.GetString(2);
                        int concertId = reader.GetInt32(3);
                        string concertName = reader.GetString(4);
                        DateTime savedDate = reader.GetDateTime(5);

                        ListViewItem item = new ListViewItem(bookmarkId.ToString());
                        item.SubItems.Add(userName);
                        item.SubItems.Add(concertId.ToString());
                        item.SubItems.Add(concertName);
                        item.SubItems.Add(savedDate.ToString("yyyy-MM-dd"));

                        lbBookmark.Items.Add(item);
                    }

                    if (lbBookmark.Items.Count == 0)
                    {
                        ListViewItem empty = new ListViewItem("No bookmarks found.");
                        lbBookmark.Items.Add(empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookmarks: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_userId);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}

