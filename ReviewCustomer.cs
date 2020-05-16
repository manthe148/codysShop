using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodysShop
{
    public partial class ReviewCustomer : Form
    {
        public ReviewCustomer()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void ReviewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.shopDataSet.Customers);

        }

        private void fillByPhoneToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByPhone(this.shopDataSet.Customers, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(phoneToolStripTextBox.Text, typeof(decimal))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
