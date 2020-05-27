using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CodysShop
{
    public partial class inventoryStore : Form
    {
        public inventoryStore()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shopInventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shopInventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopInventory);

        }

        private void inventoryStore_Load(object sender, EventArgs e)
        {

            try
            {
                string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Shop.mdf;Integrated Security=True";
                string Query = " SELECT InventoryID, ItemDescription, Date, Vendor, ItemName, ItemCost, ItemMarkUp, Sku, InStock, Parts, Shop FROM ShopInventory WHERE Shop = 'true';";
                SqlConnection connect = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand(Query, connect);
                //connect.Open();
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dtable = new DataTable();
                MyAdapter.Fill(dtable);
                dataGridView1.DataSource = dtable;


            }
            catch (Exception)
            {

                throw;
            }
            // TODO: This line of code loads data into the 'shopInventory._ShopInventory' table. You can move, or remove it, as needed.
            this.shopInventoryTableAdapter.Fill(this.shopInventory._ShopInventory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //counter++;
                this.Validate();
                this.shopInventoryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopInventory);
                this.shopInventoryBindingSource.AddNew();
                //customerIDTextBox.Text = counter.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ShopInv si = new ShopInv();
            si.Show();
        }

    }
}
