using SysLogit.Business.Contracts;
using SysLogit.Business.Services;
using SysLogit.Utility;
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
    public partial class ManageInventory : Form
    {
        private readonly IProductService _productService;
        public ManageInventory(IProductService productService)
        {
            InitializeComponent();
            _productService = productService ?? throw new ArgumentNullException(nameof(productService)); ;
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            panelProductEntry.Visible = true;
        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            
        }

        private void PopulateDataGrid()
        {
            try
            {
                // Call the business layer method to get data
                var response = _productService.GetAllProducts();

                if (response.Data != null)
                {
                    // Bind the data to the DataGridView
                    dgInventory.DataSource = response.Data.ToList();
                }
                else
                {
                    MessageBox.Show(response.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(PopulateDataGrid), ex);
                MessageBox.Show("An error occurred while loading data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductLoadData_Click(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }
    }
}
