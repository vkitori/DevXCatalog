using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevXCatalog
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.product_details' table. You can move, or remove it, as needed.
            this.product_detailsTableAdapter.Fill(this.databaseDataSet.product_details);
            // TODO: This line of code loads data into the 'databaseDataSet.product_with_specifications' table. You can move, or remove it, as needed.
            this.product_with_specificationsTableAdapter.Fill(this.databaseDataSet.product_with_specifications);
            

        }

        private void product_detailsGridControl_Click(object sender, EventArgs e)
        {

        }

        private void gridSplitContainer1Grid_Click(object sender, EventArgs e)
        {

        }
    }
}