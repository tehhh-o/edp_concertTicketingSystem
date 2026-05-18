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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            signup form2 = new signup();
            form2.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            signup form2 = new signup();
            form2.Show();
            this.Hide();
//jangankan gunung furqan gunung aqil pun aku tahan
        }
    }
}
