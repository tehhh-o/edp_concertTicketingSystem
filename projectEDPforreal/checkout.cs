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
    public partial class checkout : Form
    {
        int concertID;
        List<string> selectedSeats;
        int userId;
        private List<Image> paymentImages = new List<Image>
        {
            Properties.Resources.visa,
            Properties.Resources.tng,
            Properties.Resources.fpx,
            Properties.Resources.qr,
        };
        public checkout(int concertID, List<string> selectedSeats, int userId)
        {
            InitializeComponent();
            this.concertID = concertID;
            this.selectedSeats = selectedSeats;
            this.userId = userId;

            LoadSelectedSeats();
            LoadCheckoutDetails();
        }

        private void LoadSelectedSeats()
        {
            lsvSeats.Items.Clear();

            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
        Integrated Security=True";

            string query =
                "SELECT s.seat_number, tt.type_name, tt.price " +
                "FROM Seat s " +
                "INNER JOIN TicketType tt ON s.ticket_type_id = tt.ticket_type_id " +
                "WHERE s.seat_number = @seatNumber " +
                "AND tt.concert_id = @concertID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                decimal totalPrice = 0;

                foreach (string seat in selectedSeats)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@seatNumber", seat);
                        cmd.Parameters.AddWithValue("@concertID", concertID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string seatNumber = reader["seat_number"].ToString();
                            string typeName = reader["type_name"].ToString();
                            decimal price = Convert.ToDecimal(reader["price"]);

                            ListViewItem item = new ListViewItem(seatNumber);
                            item.SubItems.Add(typeName);
                            item.SubItems.Add(price.ToString("F2"));

                            lsvSeats.Items.Add(item);
                            totalPrice += price;
                        }

                        reader.Close();
                    }
                }

                lblTotalPrice.Text = "RM " + totalPrice.ToString("F2");
            }
        }

        private void LoadCheckoutDetails()
        {
            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string userQuery =
                    "SELECT name, email, phone_number " +
                    "FROM [User] WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(userQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        tbUsername.Text = reader["name"].ToString();
                        tbEmail.Text = reader["email"].ToString();
                        tbPhone.Text = reader["phone_number"].ToString();
                    }
                    reader.Close();
                }

                string concertQuery =
                    "SELECT concert_name, concert_details, date " +
                    "FROM Concert WHERE concert_id = @concertId";

                using (SqlCommand cmd = new SqlCommand(concertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@concertId", concertID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        tbName.Text = reader["concert_name"].ToString();
                        tbDesc.Text = reader["concert_details"].ToString();
                        DateTime date = Convert.ToDateTime(reader["date"]);
                        tbDate.Text = date.ToString("dd MMM yyyy");
                    }
                    reader.Close();
                }
            }

            tbQuantity.Text = selectedSeats.Count.ToString();
        }

        private void checkout_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkout_Load_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cmbBxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbBxPaymentMethod.SelectedItem.ToString();

            switch (selected)
            {
                case "Credit Card":
                    picBxPayment.BackgroundImage = paymentImages[0];
                    grpBxPayment.Visible = true;
                    picBxQr.Visible = false;
                    btnOnlineBanking.Visible = false;
                    break;

                case "Debit Card":
                    picBxPayment.BackgroundImage = paymentImages[0];
                    grpBxPayment.Visible = true;
                    picBxQr.Visible = false;
                    btnOnlineBanking.Visible = false;
                    break;

                case "E-Wallet":
                    picBxPayment.BackgroundImage = paymentImages[1];
                    grpBxPayment.Visible = false;
                    picBxQr.Visible = true;
                    btnOnlineBanking.Visible = false;
                    break;

                case "Online Banking":
                    picBxPayment.BackgroundImage = paymentImages[2];
                    grpBxPayment.Visible = false;
                    picBxQr.Visible = false;
                    btnOnlineBanking.Visible = true;
                    break;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbBxPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method.", "Missing Payment",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString =
                 @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=|DataDirectory|\Ticket2U.mdf;
                Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Get IDs
                    int newBookingId, newTicketId, newPaymentId;
                    using (var cmd = new SqlCommand("SELECT ISNULL(MAX(booking_id),0)+1 FROM Booking", conn, transaction))
                        newBookingId = Convert.ToInt32(cmd.ExecuteScalar());
                    using (var cmd = new SqlCommand("SELECT ISNULL(MAX(ticket_id),0)+1 FROM Ticket", conn, transaction))
                        newTicketId = Convert.ToInt32(cmd.ExecuteScalar());
                    using (var cmd = new SqlCommand("SELECT ISNULL(MAX(payment_id),0)+1 FROM Payment", conn, transaction))
                        newPaymentId = Convert.ToInt32(cmd.ExecuteScalar());

                    decimal totalPrice = decimal.Parse(lblTotalPrice.Text.Replace("RM", "").Trim());

                    // Insert Booking
                    string bookingQuery = "INSERT INTO Booking (booking_id, user_id, concert_id, booking_date, total_ticket, total_price, status) " +
                                          "VALUES (@bookingId,@userId,@concertId,@bookingDate,@totalTicket,@totalPrice,@status)";
                    using (var cmd = new SqlCommand(bookingQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", newBookingId);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@concertId", concertID);
                        cmd.Parameters.AddWithValue("@bookingDate", DateTime.Today);
                        cmd.Parameters.AddWithValue("@totalTicket", selectedSeats.Count);
                        cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                        cmd.Parameters.AddWithValue("@status", "Confirmed");
                        cmd.ExecuteNonQuery();
                    }

                    // Insert Tickets
                    foreach (string seatNumber in selectedSeats)
                    {
                        int seatId = 0; string typeName = ""; decimal price = 0;

                        string seatQuery = "SELECT s.seat_id, tt.type_name, tt.price FROM Seat s " +
                                           "INNER JOIN TicketType tt ON s.ticket_type_id = tt.ticket_type_id " +
                                           "WHERE s.seat_number = @seatNumber AND tt.concert_id = @concertId";
                        using (var cmd = new SqlCommand(seatQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@seatNumber", seatNumber);
                            cmd.Parameters.AddWithValue("@concertId", concertID);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    seatId = Convert.ToInt32(reader["seat_id"]);
                                    typeName = reader["type_name"].ToString();
                                    price = Convert.ToDecimal(reader["price"]);
                                }
                            }
                        }

                        string ticketQuery = "INSERT INTO Ticket (ticket_id, booking_id, seat_number, ticket_type, price, ticket_status, seat_id) " +
                                             "VALUES (@ticketId,@bookingId,@seatNumber,@ticketType,@price,@ticketStatus,@seatId)";
                        using (var cmd = new SqlCommand(ticketQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ticketId", newTicketId++);
                            cmd.Parameters.AddWithValue("@bookingId", newBookingId);
                            cmd.Parameters.AddWithValue("@seatNumber", seatNumber);
                            cmd.Parameters.AddWithValue("@ticketType", typeName);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@ticketStatus", "Issued");
                            cmd.Parameters.AddWithValue("@seatId", seatId);
                            cmd.ExecuteNonQuery();
                        }

                        using (var cmd = new SqlCommand("UPDATE Seat SET seat_status='Booked' WHERE seat_id=@seatId", conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@seatId", seatId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Insert Payment
                    string receipt = $"RCPT-2025-{newPaymentId:D4}";
                    string paymentQuery = "INSERT INTO Payment (payment_id,booking_id,payment_method,payment_date,amount,payment_status,receipt) " +
                                          "VALUES (@paymentId,@bookingId,@paymentMethod,@paymentDate,@amount,@paymentStatus,@receipt)";
                    using (var cmd = new SqlCommand(paymentQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@paymentId", newPaymentId);
                        cmd.Parameters.AddWithValue("@bookingId", newBookingId);
                        cmd.Parameters.AddWithValue("@paymentMethod", cmbBxPaymentMethod.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@paymentDate", DateTime.Today);
                        cmd.Parameters.AddWithValue("@amount", totalPrice);
                        cmd.Parameters.AddWithValue("@paymentStatus", "Completed");
                        cmd.Parameters.AddWithValue("@receipt", receipt);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit(); // ← all or nothing

                    MessageBox.Show($"Booking confirmed!\n\nBooking ID: {newBookingId}\nReceipt: {receipt}\nTotal: RM {totalPrice:F2}",
                        "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Receipt receiptForm = new Receipt();
                    this.Hide();
                    receiptForm.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // ← undo everything if anything fails
                    MessageBox.Show("Booking failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
