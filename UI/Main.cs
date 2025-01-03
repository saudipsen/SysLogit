using SysLogit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLogit
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInventory manageInventory = new ManageInventory();
            manageInventory.Show();
        }

        private void manageShipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ManageShipment manageShipment = new ManageShipment();
            manageShipment.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
