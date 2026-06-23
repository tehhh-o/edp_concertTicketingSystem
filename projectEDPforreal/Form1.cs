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
        int userId;
        private int currentIndex = 0;

        private List<Image> eventImages = new List<Image>
    {
        Properties.Resources.OIP_4,
        Properties.Resources.OIP_5,
        Properties.Resources.OIP_7,
        Properties.Resources.OIP_8,
        Properties.Resources.OIP_9,
        Properties.Resources.OIP_2,
        Properties.Resources.OIP_10,
        Properties.Resources.OIP_12,
        Properties.Resources.OIP_13
    };
        public Form1(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup Signup = new signup();
            Signup.ShowDialog();
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eventbrowser form2 = new eventbrowser(userId);
            this.Hide();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentIndex--;

            if (currentIndex < 0)
            {
                currentIndex = eventImages.Count - 1;
            }
            pictureBox1.Image = eventImages[currentIndex];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentIndex++;

            if (currentIndex >= eventImages.Count)
            {
                currentIndex = 0;
            }
            pictureBox1.Image = eventImages[currentIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventdetail detailForm = new eventdetail(1, eventImages[0], userId);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eventdetail detailForm = new eventdetail(2, eventImages[1], userId);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eventdetail detailForm = new eventdetail(3, eventImages[2], userId);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            eventdetail detailForm = new eventdetail(4, eventImages[3], userId);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            eventdetail detailForm = new eventdetail(5, eventImages[4], userId);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            eventdetail detailForm = new eventdetail(6, eventImages[5], userId);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            eventdetail detailForm = new eventdetail(7, eventImages[6], userId);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            eventdetail detailForm = new eventdetail(8, eventImages[7], userId);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            eventdetail detailForm = new eventdetail(9, eventImages[8], userId);
            this.Hide();
            detailForm.ShowDialog();
            this.Close();
        }
    }
}
