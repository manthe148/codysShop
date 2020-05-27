using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CodysShop
{
    public partial class InventoryParts : Form
    {
    
        public InventoryParts()
        {
            InitializeComponent();
            
        }
        

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void InventoryParts_Load_1(object sender, EventArgs e)
        {

            try
            {
                string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Shop.mdf;Integrated Security=True";
                string Query = " SELECT InventoryID, ItemDescription, Date, Vendor, ItemName, ItemCost, ItemMarkUp, Sku, InStock, Parts, Shop FROM ShopInventory WHERE Parts = 'true';";
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PartsInv pi = new PartsInv();
            pi.Show();
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
