using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodysShop
{

    public partial class BullPitIntake : Form
    {
        public BullPitIntake()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wrekerIntakeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wrekerIntakeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet1);

        }

        private void BullPitIntake_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.shopDataSet.Customers);
            // TODO: This line of code loads data into the 'shopDataSet1.WrekerIntake' table. You can move, or remove it, as needed.
            this.wrekerIntakeTableAdapter.Fill(this.shopDataSet1.WrekerIntake);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.wrekerIntakeBindingSource.EndEdit();
            this.wrekerIntakeTableAdapter.Update(this.shopDataSet1);
            this.wrekerIntakeBindingSource.AddNew();
            try
            {
                // this.wrekerIntakeBindingSource.EndEdit();
                // this.wrekerIntakeTableAdapter.Update(this.shopDataSet1);
                // this.wrekerIntakeBindingSource.AddNew();
                // MessageBox.Show("entered");

            }
            catch (Exception)
            {

                throw;
            }

        }






        
    }
}
