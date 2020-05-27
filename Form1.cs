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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void CustomDesign()
        {
            panelCustomerSubMenu.Visible = false;
            panelBullPitSubMenu.Visible = false;
            panelInventorySubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelCustomerSubMenu.Visible == true)
            {
                panelCustomerSubMenu.Visible = false;
            }
            if (panelBullPitSubMenu.Visible == true)
            {
                panelBullPitSubMenu.Visible = false;
            }
            if (panelInventorySubMenu.Visible == true)
            {
                panelInventorySubMenu.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region Add Customer Submenu
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCustomerSubMenu);
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCustomer());
            HideSubMenu();
        }

        private void BtnReviewCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new ReviewCustomer());
            HideSubMenu();
        }

        private void BtnRepairs_Click(object sender, EventArgs e)
        {
            openChildForm(new Repairs());
            HideSubMenu();
        }
        #endregion

        #region BullPit Submenu
        private void BtnBullPit_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelBullPitSubMenu);
        }

        private void BtnIntake_Click(object sender, EventArgs e)
        {
            openChildForm(new BullPitIntake());
            HideSubMenu();
        }

        private void BtnRunning_Click(object sender, EventArgs e)
        {
            openChildForm(new BullPitPartInventory());
            HideSubMenu();
        }

        #endregion

        #region
        private void BtnInventory_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelInventorySubMenu);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new InventoryManagment());
            HideSubMenu();
        }

        private void BtnInventoryStore_Click(object sender, EventArgs e)
        {
            openChildForm(new inventoryStore());
            HideSubMenu();
        }

        private void BtnParts_Click(object sender, EventArgs e)
        {
            openChildForm(new InventoryParts());
            HideSubMenu();
        }

        #endregion

        private void BtnShopSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new ShopSettings());
            HideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
