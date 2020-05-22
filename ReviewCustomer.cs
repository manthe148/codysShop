using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            Cursor.Current = Cursors.WaitCursor;
            using (ShopEntities db = new ShopEntities())
            {
                List<Customer> list = db.Customers.ToList();
                foreach (Customer c in list)
                {
                    ListViewItem item = new ListViewItem(c.CustomerID.ToString());
                    item.SubItems.Add(c.FirstName);
                    item.SubItems.Add(c.LastName);
                    item.SubItems.Add(c.Phone.ToString());
                    item.SubItems.Add(c.Make);
                    item.SubItems.Add(c.Model);
                    listView1.Items.Add(item);
                }
            }

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count >0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                using(ShopEntities db = new ShopEntities())
                {
                    string customerId = item.SubItems[0].Text;
                    Customer c = await db.Customers.FindAsync(Convert.ToInt32(customerId));
                    if (c != null)
                    {
                        using (CustomerReviewSmall crs = new CustomerReviewSmall(c))
                        {
                            if (crs.ShowDialog() == DialogResult.OK)
                            {
                                //Process
                            }
                        }
                    }
                }
            }
        }
    }   
}
