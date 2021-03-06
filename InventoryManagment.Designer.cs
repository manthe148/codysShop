﻿namespace CodysShop
{
    partial class InventoryManagment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label inventoryIDLabel;
            System.Windows.Forms.Label itemDescriptionLabel;
            System.Windows.Forms.Label vendorLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label itemCostLabel;
            System.Windows.Forms.Label itemMarkUpLabel;
            System.Windows.Forms.Label skuLabel;
            System.Windows.Forms.Label inStockLabel;
            System.Windows.Forms.Label partsLabel;
            System.Windows.Forms.Label shopLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.shopInventory = new CodysShop.ShopInventory();
            this.shopInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopInventoryTableAdapter = new CodysShop.ShopInventoryTableAdapters.ShopInventoryTableAdapter();
            this.tableAdapterManager = new CodysShop.ShopInventoryTableAdapters.TableAdapterManager();
            this.inventoryIDTextBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.vendorTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemCostTextBox = new System.Windows.Forms.TextBox();
            this.itemMarkUpTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.inStockTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.partsRadioButton = new System.Windows.Forms.RadioButton();
            this.shopRadioButton = new System.Windows.Forms.RadioButton();
            inventoryIDLabel = new System.Windows.Forms.Label();
            itemDescriptionLabel = new System.Windows.Forms.Label();
            vendorLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            itemCostLabel = new System.Windows.Forms.Label();
            itemMarkUpLabel = new System.Windows.Forms.Label();
            skuLabel = new System.Windows.Forms.Label();
            inStockLabel = new System.Windows.Forms.Label();
            partsLabel = new System.Windows.Forms.Label();
            shopLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryIDLabel
            // 
            inventoryIDLabel.AutoSize = true;
            inventoryIDLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            inventoryIDLabel.Location = new System.Drawing.Point(487, 59);
            inventoryIDLabel.Name = "inventoryIDLabel";
            inventoryIDLabel.Size = new System.Drawing.Size(161, 34);
            inventoryIDLabel.TabIndex = 3;
            inventoryIDLabel.Text = "Inventory ID:";
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemDescriptionLabel.Location = new System.Drawing.Point(413, 113);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new System.Drawing.Size(216, 34);
            itemDescriptionLabel.TabIndex = 5;
            itemDescriptionLabel.Text = "Item Description:";
            // 
            // vendorLabel
            // 
            vendorLabel.AutoSize = true;
            vendorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            vendorLabel.Location = new System.Drawing.Point(22, 101);
            vendorLabel.Name = "vendorLabel";
            vendorLabel.Size = new System.Drawing.Size(104, 34);
            vendorLabel.TabIndex = 9;
            vendorLabel.Text = "Vendor:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemNameLabel.Location = new System.Drawing.Point(22, 59);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(154, 34);
            itemNameLabel.TabIndex = 11;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemCostLabel
            // 
            itemCostLabel.AutoSize = true;
            itemCostLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemCostLabel.Location = new System.Drawing.Point(22, 141);
            itemCostLabel.Name = "itemCostLabel";
            itemCostLabel.Size = new System.Drawing.Size(134, 34);
            itemCostLabel.TabIndex = 13;
            itemCostLabel.Text = "Item Cost:";
            // 
            // itemMarkUpLabel
            // 
            itemMarkUpLabel.AutoSize = true;
            itemMarkUpLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemMarkUpLabel.Location = new System.Drawing.Point(22, 181);
            itemMarkUpLabel.Name = "itemMarkUpLabel";
            itemMarkUpLabel.Size = new System.Drawing.Size(181, 34);
            itemMarkUpLabel.TabIndex = 15;
            itemMarkUpLabel.Text = "Item Mark Up:";
            // 
            // skuLabel
            // 
            skuLabel.AutoSize = true;
            skuLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            skuLabel.Location = new System.Drawing.Point(22, 223);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new System.Drawing.Size(66, 34);
            skuLabel.TabIndex = 17;
            skuLabel.Text = "Sku:";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            inStockLabel.Location = new System.Drawing.Point(22, 265);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new System.Drawing.Size(116, 34);
            inStockLabel.TabIndex = 19;
            inStockLabel.Text = "In Stock:";
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            partsLabel.Location = new System.Drawing.Point(22, 316);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new System.Drawing.Size(83, 34);
            partsLabel.TabIndex = 25;
            partsLabel.Text = "Parts:";
            // 
            // shopLabel
            // 
            shopLabel.AutoSize = true;
            shopLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            shopLabel.Location = new System.Drawing.Point(24, 356);
            shopLabel.Name = "shopLabel";
            shopLabel.Size = new System.Drawing.Size(81, 34);
            shopLabel.TabIndex = 26;
            shopLabel.Text = "Shop:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 51);
            this.panel1.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(12, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // shopInventory
            // 
            this.shopInventory.DataSetName = "ShopInventory";
            this.shopInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopInventoryBindingSource
            // 
            this.shopInventoryBindingSource.DataMember = "ShopInventory";
            this.shopInventoryBindingSource.DataSource = this.shopInventory;
            // 
            // shopInventoryTableAdapter
            // 
            this.shopInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ShopInventoryTableAdapter = this.shopInventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = CodysShop.ShopInventoryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryIDTextBox
            // 
            this.inventoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "InventoryID", true));
            this.inventoryIDTextBox.Location = new System.Drawing.Point(720, 71);
            this.inventoryIDTextBox.Name = "inventoryIDTextBox";
            this.inventoryIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryIDTextBox.TabIndex = 4;
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemDescription", true));
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(419, 155);
            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(401, 130);
            this.itemDescriptionTextBox.TabIndex = 6;
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "Vendor", true));
            this.vendorTextBox.Location = new System.Drawing.Point(255, 113);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorTextBox.TabIndex = 10;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(255, 71);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNameTextBox.TabIndex = 12;
            // 
            // itemCostTextBox
            // 
            this.itemCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemCost", true));
            this.itemCostTextBox.Location = new System.Drawing.Point(255, 151);
            this.itemCostTextBox.Name = "itemCostTextBox";
            this.itemCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemCostTextBox.TabIndex = 14;
            // 
            // itemMarkUpTextBox
            // 
            this.itemMarkUpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemMarkUp", true));
            this.itemMarkUpTextBox.Location = new System.Drawing.Point(255, 193);
            this.itemMarkUpTextBox.Name = "itemMarkUpTextBox";
            this.itemMarkUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemMarkUpTextBox.TabIndex = 16;
            // 
            // skuTextBox
            // 
            this.skuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "Sku", true));
            this.skuTextBox.Location = new System.Drawing.Point(255, 235);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(100, 20);
            this.skuTextBox.TabIndex = 18;
            // 
            // inStockTextBox
            // 
            this.inStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "InStock", true));
            this.inStockTextBox.Location = new System.Drawing.Point(255, 277);
            this.inStockTextBox.Name = "inStockTextBox";
            this.inStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.inStockTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 25;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // partsRadioButton
            // 
            this.partsRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.shopInventoryBindingSource, "Parts", true));
            this.partsRadioButton.Location = new System.Drawing.Point(255, 325);
            this.partsRadioButton.Name = "partsRadioButton";
            this.partsRadioButton.Size = new System.Drawing.Size(104, 24);
            this.partsRadioButton.TabIndex = 26;
            this.partsRadioButton.TabStop = true;
            this.partsRadioButton.UseVisualStyleBackColor = true;
            // 
            // shopRadioButton
            // 
            this.shopRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.shopInventoryBindingSource, "Shop", true));
            this.shopRadioButton.Location = new System.Drawing.Point(255, 365);
            this.shopRadioButton.Name = "shopRadioButton";
            this.shopRadioButton.Size = new System.Drawing.Size(104, 24);
            this.shopRadioButton.TabIndex = 27;
            this.shopRadioButton.TabStop = true;
            this.shopRadioButton.UseVisualStyleBackColor = true;
            this.shopRadioButton.CheckedChanged += new System.EventHandler(this.shopRadioButton_CheckedChanged);
            // 
            // InventoryManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.Controls.Add(shopLabel);
            this.Controls.Add(this.shopRadioButton);
            this.Controls.Add(partsLabel);
            this.Controls.Add(this.partsRadioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(inventoryIDLabel);
            this.Controls.Add(this.inventoryIDTextBox);
            this.Controls.Add(itemDescriptionLabel);
            this.Controls.Add(this.itemDescriptionTextBox);
            this.Controls.Add(vendorLabel);
            this.Controls.Add(this.vendorTextBox);
            this.Controls.Add(itemNameLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(itemCostLabel);
            this.Controls.Add(this.itemCostTextBox);
            this.Controls.Add(itemMarkUpLabel);
            this.Controls.Add(this.itemMarkUpTextBox);
            this.Controls.Add(skuLabel);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(inStockLabel);
            this.Controls.Add(this.inStockTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryManagment";
            this.Text = "InventoryManagment";
            this.Load += new System.EventHandler(this.InventoryManagment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private ShopInventory shopInventory;
        private System.Windows.Forms.BindingSource shopInventoryBindingSource;
        private ShopInventoryTableAdapters.ShopInventoryTableAdapter shopInventoryTableAdapter;
        private ShopInventoryTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox inventoryIDTextBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox vendorTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemCostTextBox;
        private System.Windows.Forms.TextBox itemMarkUpTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.TextBox inStockTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton partsRadioButton;
        private System.Windows.Forms.RadioButton shopRadioButton;
    }
}