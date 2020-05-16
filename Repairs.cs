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
    public partial class Repairs : Form
    {
        public Repairs()
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

        private void Repairs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.shopDataSet.Customers);

        }

        private void fillBy1lastNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillBy1lastName(this.shopDataSet.Customers, lastNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopDataSet);
                MessageBox.Show(string.Format("repairs entered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));
            }
            catch (Exception)
            {

                MessageBox.Show("error please check data and try again!");
            }
            
            
        }
    }
}
