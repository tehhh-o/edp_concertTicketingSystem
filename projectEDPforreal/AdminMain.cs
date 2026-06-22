using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectEDPforreal
{
    public partial class AdminMain : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\edp_concertTicketingSystem\projectEDPforreal\Ticket2U.mdf;Integrated Security=True");

        public AdminMain()
        {
            InitializeComponent();
        }

        private void concertBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.concertBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticket2U);
        }

        private void concertBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
        }

        private void AdminMain_Load_1(object sender, EventArgs e)
        {
            this.concertTableAdapter.Fill(this.ticket2U.Concert);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Concert] (concert_id, concert_name, concert_details, date, ticket_price, available_seat) " + "values ('" + ConIdTB.Text + "','" + ConNameTB.Text + "','" + ConDetailTB.Text + "','" + DateDTP.Value.ToString("yyyy-MM-dd") + "','" + TicPriceTB.Text + "','" + SeatTB.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            ConIdTB.Text = "";
            ConNameTB.Text = "";
            ConDetailTB.Text = "";
            DateDTP.Value = DateTime.Now;
            TicPriceTB.Text = "";
            SeatTB.Text = "";
            MessageBox.Show("Data inserted successfully");
            this.concertTableAdapter.Fill(this.ticket2U.Concert);
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Concert] where [concert_id] = " + ConIdTB.Text + "";
            cmd.ExecuteNonQuery();
            connection.Close();
            ConIdTB.Text = "";
            MessageBox.Show("Data deleted successfully");
            this.concertTableAdapter.Fill(this.ticket2U.Concert);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Concert] set concert_name = '" + ConNameTB.Text + "', concert_details = '" + ConDetailTB.Text + "', date = '" + DateDTP.Value.ToString("yyyy-MM-dd") + "', ticket_price = '" + TicPriceTB.Text + "', available_seat = '" + SeatTB.Text + "' where concert_id = '" + ConIdTB.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            ConIdTB.Text = "";
            ConNameTB.Text = "";
            ConDetailTB.Text = "";
            DateDTP.Value = DateTime.Now;
            TicPriceTB.Text = "";
            SeatTB.Text = "";
            MessageBox.Show("Data updated successfully");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ConIdTB.Clear();
            ConNameTB.Clear();
            ConDetailTB.Clear();
            DateDTP.Value = DateTime.Now;
            TicPriceTB.Clear();
            SeatTB.Clear();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }
    }
}