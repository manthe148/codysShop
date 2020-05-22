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
            // TODO: This line of code loads data into the 'shopInventory._ShopInventory' table. You can move, or remove it, as needed.
            this.shopInventoryTableAdapter.Fill(this.shopInventory._ShopInventory);

        }
    }
}
