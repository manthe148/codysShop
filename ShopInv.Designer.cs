namespace CodysShop
{
    partial class ShopInv
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
            System.Windows.Forms.Label shopLabel;
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
            this.shopRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            inventoryIDLabel = new System.Windows.Forms.Label();
            itemDescriptionLabel = new System.Windows.Forms.Label();
            vendorLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            itemCostLabel = new System.Windows.Forms.Label();
            itemMarkUpLabel = new System.Windows.Forms.Label();
            skuLabel = new System.Windows.Forms.Label();
            inStockLabel = new System.Windows.Forms.Label();
            shopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryIDLabel
            // 
            inventoryIDLabel.AutoSize = true;
            inventoryIDLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            inventoryIDLabel.Location = new System.Drawing.Point(12, 25);
            inventoryIDLabel.Name = "inventoryIDLabel";
            inventoryIDLabel.Size = new System.Drawing.Size(161, 34);
            inventoryIDLabel.TabIndex = 1;
            inventoryIDLabel.Text = "Inventory ID:";
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemDescriptionLabel.Location = new System.Drawing.Point(385, 37);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new System.Drawing.Size(216, 34);
            itemDescriptionLabel.TabIndex = 3;
            itemDescriptionLabel.Text = "Item Description:";
            // 
            // vendorLabel
            // 
            vendorLabel.AutoSize = true;
            vendorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            vendorLabel.Location = new System.Drawing.Point(12, 106);
            vendorLabel.Name = "vendorLabel";
            vendorLabel.Size = new System.Drawing.Size(104, 34);
            vendorLabel.TabIndex = 7;
            vendorLabel.Text = "Vendor:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemNameLabel.Location = new System.Drawing.Point(12, 66);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(154, 34);
            itemNameLabel.TabIndex = 9;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemCostLabel
            // 
            itemCostLabel.AutoSize = true;
            itemCostLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemCostLabel.Location = new System.Drawing.Point(12, 145);
            itemCostLabel.Name = "itemCostLabel";
            itemCostLabel.Size = new System.Drawing.Size(134, 34);
            itemCostLabel.TabIndex = 11;
            itemCostLabel.Text = "Item Cost:";
            // 
            // itemMarkUpLabel
            // 
            itemMarkUpLabel.AutoSize = true;
            itemMarkUpLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemMarkUpLabel.Location = new System.Drawing.Point(12, 187);
            itemMarkUpLabel.Name = "itemMarkUpLabel";
            itemMarkUpLabel.Size = new System.Drawing.Size(181, 34);
            itemMarkUpLabel.TabIndex = 13;
            itemMarkUpLabel.Text = "Item Mark Up:";
            // 
            // skuLabel
            // 
            skuLabel.AutoSize = true;
            skuLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            skuLabel.Location = new System.Drawing.Point(12, 229);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new System.Drawing.Size(66, 34);
            skuLabel.TabIndex = 15;
            skuLabel.Text = "Sku:";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            inStockLabel.Location = new System.Drawing.Point(12, 271);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new System.Drawing.Size(116, 34);
            inStockLabel.TabIndex = 17;
            inStockLabel.Text = "In Stock:";
            // 
            // shopLabel
            // 
            shopLabel.AutoSize = true;
            shopLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            shopLabel.Location = new System.Drawing.Point(12, 318);
            shopLabel.Name = "shopLabel";
            shopLabel.Size = new System.Drawing.Size(81, 34);
            shopLabel.TabIndex = 21;
            shopLabel.Text = "Shop:";
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
            this.inventoryIDTextBox.Location = new System.Drawing.Point(212, 37);
            this.inventoryIDTextBox.Name = "inventoryIDTextBox";
            this.inventoryIDTextBox.ReadOnly = true;
            this.inventoryIDTextBox.Size = new System.Drawing.Size(140, 20);
            this.inventoryIDTextBox.TabIndex = 2;
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemDescription", true));
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(391, 78);
            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(397, 158);
            this.itemDescriptionTextBox.TabIndex = 4;
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "Vendor", true));
            this.vendorTextBox.Location = new System.Drawing.Point(212, 110);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(140, 20);
            this.vendorTextBox.TabIndex = 8;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(212, 78);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.itemNameTextBox.TabIndex = 10;
            // 
            // itemCostTextBox
            // 
            this.itemCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemCost", true));
            this.itemCostTextBox.Location = new System.Drawing.Point(212, 157);
            this.itemCostTextBox.Name = "itemCostTextBox";
            this.itemCostTextBox.Size = new System.Drawing.Size(140, 20);
            this.itemCostTextBox.TabIndex = 12;
            // 
            // itemMarkUpTextBox
            // 
            this.itemMarkUpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemMarkUp", true));
            this.itemMarkUpTextBox.Location = new System.Drawing.Point(212, 199);
            this.itemMarkUpTextBox.Name = "itemMarkUpTextBox";
            this.itemMarkUpTextBox.Size = new System.Drawing.Size(140, 20);
            this.itemMarkUpTextBox.TabIndex = 14;
            // 
            // skuTextBox
            // 
            this.skuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "Sku", true));
            this.skuTextBox.Location = new System.Drawing.Point(212, 241);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(140, 20);
            this.skuTextBox.TabIndex = 16;
            // 
            // inStockTextBox
            // 
            this.inStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "InStock", true));
            this.inStockTextBox.Location = new System.Drawing.Point(212, 283);
            this.inStockTextBox.Name = "inStockTextBox";
            this.inStockTextBox.Size = new System.Drawing.Size(140, 20);
            this.inStockTextBox.TabIndex = 18;
            // 
            // shopRadioButton
            // 
            this.shopRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.shopInventoryBindingSource, "Shop", true));
            this.shopRadioButton.Location = new System.Drawing.Point(212, 327);
            this.shopRadioButton.Name = "shopRadioButton";
            this.shopRadioButton.Size = new System.Drawing.Size(104, 24);
            this.shopRadioButton.TabIndex = 22;
            this.shopRadioButton.TabStop = true;
            this.shopRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 44);
            this.button1.TabIndex = 42;
            this.button1.Text = "&Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShopInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(shopLabel);
            this.Controls.Add(this.shopRadioButton);
            this.Name = "ShopInv";
            this.Text = "StorInv";
            this.Load += new System.EventHandler(this.StorInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.RadioButton shopRadioButton;
        private System.Windows.Forms.Button button1;
    }
}