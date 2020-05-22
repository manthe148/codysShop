namespace CodysShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubMenu = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.panelInventorySubMenu = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.BtnParts = new System.Windows.Forms.Button();
            this.BtnInventoryStore = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.panelBullPitSubMenu = new System.Windows.Forms.Panel();
            this.BtnBullPitPartsInventory = new System.Windows.Forms.Button();
            this.BtnIntake = new System.Windows.Forms.Button();
            this.BtnBullPit = new System.Windows.Forms.Button();
            this.panelCustomerSubMenu = new System.Windows.Forms.Panel();
            this.BtnRepairs = new System.Windows.Forms.Button();
            this.BtnReviewCustomer = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.BtnBullPitTotaledInventory = new System.Windows.Forms.Button();
            this.SubMenu.SuspendLayout();
            this.panelInventorySubMenu.SuspendLayout();
            this.panelBullPitSubMenu.SuspendLayout();
            this.panelCustomerSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubMenu
            // 
            this.SubMenu.AutoScroll = true;
            this.SubMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubMenu.Controls.Add(this.BtnHelp);
            this.SubMenu.Controls.Add(this.panelInventorySubMenu);
            this.SubMenu.Controls.Add(this.BtnInventory);
            this.SubMenu.Controls.Add(this.panelBullPitSubMenu);
            this.SubMenu.Controls.Add(this.BtnBullPit);
            this.SubMenu.Controls.Add(this.panelCustomerSubMenu);
            this.SubMenu.Controls.Add(this.BtnCustomers);
            this.SubMenu.Controls.Add(this.panelLogo);
            this.SubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubMenu.Location = new System.Drawing.Point(0, 0);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(200, 617);
            this.SubMenu.TabIndex = 0;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHelp.Location = new System.Drawing.Point(0, 567);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(200, 45);
            this.BtnHelp.TabIndex = 0;
            this.BtnHelp.Text = "HELP";
            this.BtnHelp.UseVisualStyleBackColor = true;
            // 
            // panelInventorySubMenu
            // 
            this.panelInventorySubMenu.Controls.Add(this.button12);
            this.panelInventorySubMenu.Controls.Add(this.BtnParts);
            this.panelInventorySubMenu.Controls.Add(this.BtnInventoryStore);
            this.panelInventorySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventorySubMenu.Location = new System.Drawing.Point(0, 442);
            this.panelInventorySubMenu.Name = "panelInventorySubMenu";
            this.panelInventorySubMenu.Size = new System.Drawing.Size(200, 125);
            this.panelInventorySubMenu.TabIndex = 6;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.Location = new System.Drawing.Point(0, 80);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(200, 40);
            this.button12.TabIndex = 2;
            this.button12.Text = "Inventory Management";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // BtnParts
            // 
            this.BtnParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnParts.Location = new System.Drawing.Point(0, 40);
            this.BtnParts.Name = "BtnParts";
            this.BtnParts.Size = new System.Drawing.Size(200, 40);
            this.BtnParts.TabIndex = 1;
            this.BtnParts.Text = "Parts";
            this.BtnParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnParts.UseVisualStyleBackColor = true;
            this.BtnParts.Click += new System.EventHandler(this.BtnParts_Click);
            // 
            // BtnInventoryStore
            // 
            this.BtnInventoryStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventoryStore.Location = new System.Drawing.Point(0, 0);
            this.BtnInventoryStore.Name = "BtnInventoryStore";
            this.BtnInventoryStore.Size = new System.Drawing.Size(200, 40);
            this.BtnInventoryStore.TabIndex = 0;
            this.BtnInventoryStore.Text = "Store";
            this.BtnInventoryStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventoryStore.UseVisualStyleBackColor = true;
            this.BtnInventoryStore.Click += new System.EventHandler(this.BtnInventoryStore_Click);
            // 
            // BtnInventory
            // 
            this.BtnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventory.FlatAppearance.BorderSize = 0;
            this.BtnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventory.Location = new System.Drawing.Point(0, 397);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(200, 45);
            this.BtnInventory.TabIndex = 5;
            this.BtnInventory.Text = "Inventory";
            this.BtnInventory.UseVisualStyleBackColor = true;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // panelBullPitSubMenu
            // 
            this.panelBullPitSubMenu.Controls.Add(this.BtnBullPitTotaledInventory);
            this.panelBullPitSubMenu.Controls.Add(this.BtnBullPitPartsInventory);
            this.panelBullPitSubMenu.Controls.Add(this.BtnIntake);
            this.panelBullPitSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBullPitSubMenu.Location = new System.Drawing.Point(0, 273);
            this.panelBullPitSubMenu.Name = "panelBullPitSubMenu";
            this.panelBullPitSubMenu.Size = new System.Drawing.Size(200, 124);
            this.panelBullPitSubMenu.TabIndex = 4;
            // 
            // BtnBullPitPartsInventory
            // 
            this.BtnBullPitPartsInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBullPitPartsInventory.Location = new System.Drawing.Point(0, 40);
            this.BtnBullPitPartsInventory.Name = "BtnBullPitPartsInventory";
            this.BtnBullPitPartsInventory.Size = new System.Drawing.Size(200, 40);
            this.BtnBullPitPartsInventory.TabIndex = 1;
            this.BtnBullPitPartsInventory.Text = "Parts Inventory";
            this.BtnBullPitPartsInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBullPitPartsInventory.UseVisualStyleBackColor = true;
            this.BtnBullPitPartsInventory.Click += new System.EventHandler(this.BtnRunning_Click);
            // 
            // BtnIntake
            // 
            this.BtnIntake.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIntake.Location = new System.Drawing.Point(0, 0);
            this.BtnIntake.Name = "BtnIntake";
            this.BtnIntake.Size = new System.Drawing.Size(200, 40);
            this.BtnIntake.TabIndex = 0;
            this.BtnIntake.Text = "Wrecker Intake";
            this.BtnIntake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIntake.UseVisualStyleBackColor = true;
            this.BtnIntake.Click += new System.EventHandler(this.BtnIntake_Click);
            // 
            // BtnBullPit
            // 
            this.BtnBullPit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBullPit.FlatAppearance.BorderSize = 0;
            this.BtnBullPit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBullPit.Location = new System.Drawing.Point(0, 228);
            this.BtnBullPit.Name = "BtnBullPit";
            this.BtnBullPit.Size = new System.Drawing.Size(200, 45);
            this.BtnBullPit.TabIndex = 3;
            this.BtnBullPit.Text = "Bull Pit";
            this.BtnBullPit.UseVisualStyleBackColor = true;
            this.BtnBullPit.Click += new System.EventHandler(this.BtnBullPit_Click);
            // 
            // panelCustomerSubMenu
            // 
            this.panelCustomerSubMenu.Controls.Add(this.BtnRepairs);
            this.panelCustomerSubMenu.Controls.Add(this.BtnReviewCustomer);
            this.panelCustomerSubMenu.Controls.Add(this.BtnAddCustomer);
            this.panelCustomerSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerSubMenu.Location = new System.Drawing.Point(0, 102);
            this.panelCustomerSubMenu.Name = "panelCustomerSubMenu";
            this.panelCustomerSubMenu.Size = new System.Drawing.Size(200, 126);
            this.panelCustomerSubMenu.TabIndex = 2;
            // 
            // BtnRepairs
            // 
            this.BtnRepairs.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRepairs.Location = new System.Drawing.Point(0, 80);
            this.BtnRepairs.Name = "BtnRepairs";
            this.BtnRepairs.Size = new System.Drawing.Size(200, 40);
            this.BtnRepairs.TabIndex = 2;
            this.BtnRepairs.Text = "Repairs";
            this.BtnRepairs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRepairs.UseVisualStyleBackColor = true;
            this.BtnRepairs.Click += new System.EventHandler(this.BtnRepairs_Click);
            // 
            // BtnReviewCustomer
            // 
            this.BtnReviewCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReviewCustomer.Location = new System.Drawing.Point(0, 40);
            this.BtnReviewCustomer.Name = "BtnReviewCustomer";
            this.BtnReviewCustomer.Size = new System.Drawing.Size(200, 40);
            this.BtnReviewCustomer.TabIndex = 1;
            this.BtnReviewCustomer.Text = "Review Customer";
            this.BtnReviewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReviewCustomer.UseVisualStyleBackColor = true;
            this.BtnReviewCustomer.Click += new System.EventHandler(this.BtnReviewCustomer_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddCustomer.Location = new System.Drawing.Point(0, 0);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(200, 40);
            this.BtnAddCustomer.TabIndex = 0;
            this.BtnAddCustomer.Text = "Add Customer";
            this.BtnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustomers.FlatAppearance.BorderSize = 0;
            this.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomers.Location = new System.Drawing.Point(0, 57);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(200, 45);
            this.BtnCustomers.TabIndex = 1;
            this.BtnCustomers.Text = "Customers";
            this.BtnCustomers.UseVisualStyleBackColor = true;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 57);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(885, 617);
            this.panelChildForm.TabIndex = 1;
            // 
            // BtnBullPitTotaledInventory
            // 
            this.BtnBullPitTotaledInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBullPitTotaledInventory.Location = new System.Drawing.Point(0, 80);
            this.BtnBullPitTotaledInventory.Name = "BtnBullPitTotaledInventory";
            this.BtnBullPitTotaledInventory.Size = new System.Drawing.Size(200, 40);
            this.BtnBullPitTotaledInventory.TabIndex = 2;
            this.BtnBullPitTotaledInventory.Text = "Totaled Inventory";
            this.BtnBullPitTotaledInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBullPitTotaledInventory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1085, 617);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.SubMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SubMenu.ResumeLayout(false);
            this.panelInventorySubMenu.ResumeLayout(false);
            this.panelBullPitSubMenu.ResumeLayout(false);
            this.panelCustomerSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SubMenu;
        private System.Windows.Forms.Panel panelCustomerSubMenu;
        private System.Windows.Forms.Button BtnRepairs;
        private System.Windows.Forms.Button BtnReviewCustomer;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelInventorySubMenu;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button BtnParts;
        private System.Windows.Forms.Button BtnInventoryStore;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Panel panelBullPitSubMenu;
        private System.Windows.Forms.Button BtnBullPitPartsInventory;
        private System.Windows.Forms.Button BtnIntake;
        private System.Windows.Forms.Button BtnBullPit;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnBullPitTotaledInventory;
    }
}

