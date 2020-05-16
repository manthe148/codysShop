using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodysShop
{
    public partial class AddCustomer : Form
    {
        int counter = 1000;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.shopDataSet.Customers);



            // TODO: This line of code loads data into the 'shopDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.shopDataSet.Customers);

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopDataSet);
                this.customersBindingSource.AddNew();
                MessageBox.Show(string.Format("{0} is entered in the system", firstNameTextBox.Text, MessageBoxButtons.OK));
            }
            catch (System.Exception)
            {

                MessageBox.Show("update failed");
            }

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnClear_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            streetTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
            unitTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipTextBox.Clear();
            yearTextBox.Clear();
            makeTextBox.Clear();
            modelTextBox.Clear();
            vinTextBox.Clear();
            mileageTextBox.Clear();
            licensePlateTextBox.Clear();
            complaintsTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //counter++;
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopDataSet);
                this.customersBindingSource.AddNew();
                //customerIDTextBox.Text = counter.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
           
        }

    }
}
