using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectEDPforreal
{
    public partial class signup : Form
    {
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
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
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
    }
}
