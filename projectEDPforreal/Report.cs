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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void concertBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.concertBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ticket2U);

        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticket2U.Concert' table. You can move, or remove it, as needed.
            this.concertTableAdapter.Fill(this.ticket2U.Concert);

        }
    }
}
