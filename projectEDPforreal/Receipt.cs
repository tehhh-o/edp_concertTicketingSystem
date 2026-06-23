using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectEDPforreal
{
    public partial class Receipt : Form
    {
        int userid;

        public Receipt(
            int id,
            string name,
            string phone,
            int paymentId,
            int bookingId,
            string paymentMethod,
            DateTime paymentDate,
            decimal amount,
            string status,
            string receiptId)
        {
            InitializeComponent();

            // Assigning the passed data into your UI TextBoxes
            this.userid = id;
            tbName.Text = name;
            tbPhone.Text = phone;
            tbPaymentId.Text = paymentId.ToString();
            tbBookingId.Text = bookingId.ToString();
            tbPaymentMethod.Text = paymentMethod;
            tbPaymentDate.Text = paymentDate.ToString("dd MMM yyyy");
            tbAmount.Text = "RM " + amount.ToString("F2");
            tbPaymentStatus.Text = status;
            tbReceiptId.Text = receiptId;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(userid);
            this.Hide();
            form1.ShowDialog();
        }
    }
}
