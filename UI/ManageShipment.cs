using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLogit.UI
{
    public partial class ManageShipment : Form
    {
        public ManageShipment()
        {
            InitializeComponent();
        }

        private void btnCreateShipment_Click(object sender, EventArgs e)
        {
            panelShipment.Visible = true;
        }

        private void panelShipment_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
