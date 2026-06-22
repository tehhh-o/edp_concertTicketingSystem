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
using System.Windows.Forms.DataVisualization.Charting; 

namespace projectEDPforreal
{
    public partial class Report : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\edp_concertTicketingSystem\projectEDPforreal\Ticket2U.mdf;Integrated Security=True");

        public Report()
        {
            InitializeComponent();
        }

        private void bookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticket2U);
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.bookingTableAdapter.Fill(this.ticket2U.Booking);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Booking] where user_id = " + SearchTbox.Text + "";
            cmd.ExecuteNonQuery();
            DataTable datatbl = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(datatbl);
            bookingDataGridView.DataSource = datatbl;
            connection.Close();
            SearchTbox.Text = "";
        }

        private void SortTotTicBtn_Click(object sender, EventArgs e)
        {
            if (bookingDataGridView.DataSource != null)
            {
                DataView dv = ObjectToDatView(bookingDataGridView.DataSource);
                if (dv != null)
                {
                    dv.Sort = "total_ticket DESC";
                    bookingDataGridView.DataSource = dv.ToTable();
                }
            }
        }

        private void SortDateBtn_Click(object sender, EventArgs e)
        {
            if (bookingDataGridView.DataSource != null)
            {
                DataView dv = ObjectToDatView(bookingDataGridView.DataSource);
                if (dv != null)
                {
                    dv.Sort = "booking_date DESC"; 
                    bookingDataGridView.DataSource = dv.ToTable();
                }
            }
        }

        private void GenChartButton_Click(object sender, EventArgs e)
        {
            if (bookingDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Tiada data dalam jadual untuk dijana sebagai graf.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Dictionary<string, string> namaKonsertDb = new Dictionary<string, string>();

            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT concert_id, concert_name FROM [Concert]";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["concert_id"].ToString().Trim();
                        string nama = reader["concert_name"].ToString().Trim();
                        namaKonsertDb[id] = nama;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notes: Failed To Retrieve Concert Name From Database. Graph Will Use ID Only.\n💡 Error : " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
            }

            try
            {
                ReportChart.Series.Clear();
                ReportChart.Titles.Clear();
                ReportChart.Titles.Add("Ticket Sales Based On Concert");

                var siriJualan = new System.Windows.Forms.DataVisualization.Charting.Series("Ticket Sold")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };

                var dataGraf = bookingDataGridView.Rows.Cast<DataGridViewRow>()
                                .Where(r => !r.IsNewRow && r.Cells[2].Value != null && r.Cells[4].Value != DBNull.Value).GroupBy(r => r.Cells[2].Value.ToString().Trim()).Select(g => new 
                                {
                                    ConcertID = g.Key,
                                    TotalTickets = g.Sum(r => Convert.ToInt32(r.Cells[4].Value))
                                }).ToList();

                foreach (var item in dataGraf)
                {
                    string labelPaksiX = namaKonsertDb.ContainsKey(item.ConcertID) ? namaKonsertDb[item.ConcertID] : "ID " + item.ConcertID;

                    siriJualan.Points.AddXY(labelPaksiX, item.TotalTickets);
                }

                ReportChart.Series.Add(siriJualan);
                ReportChart.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Generate Graph.\n\nError : " + ex.Message, "Graph Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataView ObjectToDatView(object dataSource)
        {
            if (dataSource is BindingSource bs)
            {
                if (bs.DataSource is DataSet ds && !string.IsNullOrEmpty(bs.DataMember))
                    return ds.Tables[bs.DataMember].DefaultView;
                if (bs.DataSource is DataTable dt)
                    return dt.DefaultView;
            }
            if (dataSource is DataTable table)
            {
                return table.DefaultView;
            }
            if (dataSource is DataView view)
            {
                return view;
            }
            return null;
        }

        private void ReceiptBtn_Click(object sender, EventArgs e)
        {

        }

        private void ConManBtn_Click(object sender, EventArgs e)
        {
            AdminMain admin = new AdminMain();
            admin.Show();
            this.Hide();
        }

        private void BoMarkBtn_Click(object sender, EventArgs e)
        {

        }
    }
}