namespace CodysShop
{
    partial class PartsInv
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
            System.Windows.Forms.Label inStockLabel;
            System.Windows.Forms.Label skuLabel;
            System.Windows.Forms.Label partsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsInv));
            this.inventoryIDTextBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.vendorTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemCostTextBox = new System.Windows.Forms.TextBox();
            this.itemMarkUpTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.inStockTextBox = new System.Windows.Forms.TextBox();
            this.shopInventory = new CodysShop.ShopInventory();
            this.shopInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopInventoryTableAdapter = new CodysShop.ShopInventoryTableAdapters.ShopInventoryTableAdapter();
            this.tableAdapterManager = new CodysShop.ShopInventoryTableAdapters.TableAdapterManager();
            this.shopInventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.shopInventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partsRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            inventoryIDLabel = new System.Windows.Forms.Label();
            itemDescriptionLabel = new System.Windows.Forms.Label();
            vendorLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            itemCostLabel = new System.Windows.Forms.Label();
            itemMarkUpLabel = new System.Windows.Forms.Label();
            inStockLabel = new System.Windows.Forms.Label();
            skuLabel = new System.Windows.Forms.Label();
            partsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingNavigator)).BeginInit();
            this.shopInventoryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryIDLabel
            // 
            inventoryIDLabel.AutoSize = true;
            inventoryIDLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            inventoryIDLabel.Location = new System.Drawing.Point(12, 63);
            inventoryIDLabel.Name = "inventoryIDLabel";
            inventoryIDLabel.Size = new System.Drawing.Size(161, 34);
            inventoryIDLabel.TabIndex = 23;
            inventoryIDLabel.Text = "Inventory ID:";
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemDescriptionLabel.Location = new System.Drawing.Point(385, 75);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new System.Drawing.Size(216, 34);
            itemDescriptionLabel.TabIndex = 25;
            itemDescriptionLabel.Text = "Item Description:";
            // 
            // vendorLabel
            // 
            vendorLabel.AutoSize = true;
            vendorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            vendorLabel.Location = new System.Drawing.Point(12, 144);
            vendorLabel.Name = "vendorLabel";
            vendorLabel.Size = new System.Drawing.Size(104, 34);
            vendorLabel.TabIndex = 27;
            vendorLabel.Text = "Vendor:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemNameLabel.Location = new System.Drawing.Point(12, 104);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(154, 34);
            itemNameLabel.TabIndex = 29;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemCostLabel
            // 
            itemCostLabel.AutoSize = true;
            itemCostLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemCostLabel.Location = new System.Drawing.Point(12, 183);
            itemCostLabel.Name = "itemCostLabel";
            itemCostLabel.Size = new System.Drawing.Size(134, 34);
            itemCostLabel.TabIndex = 31;
            itemCostLabel.Text = "Item Cost:";
            // 
            // itemMarkUpLabel
            // 
            itemMarkUpLabel.AutoSize = true;
            itemMarkUpLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            itemMarkUpLabel.Location = new System.Drawing.Point(12, 225);
            itemMarkUpLabel.Name = "itemMarkUpLabel";
            itemMarkUpLabel.Size = new System.Drawing.Size(181, 34);
            itemMarkUpLabel.TabIndex = 33;
            itemMarkUpLabel.Text = "Item Mark Up:";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            inStockLabel.Location = new System.Drawing.Point(12, 309);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new System.Drawing.Size(116, 34);
            inStockLabel.TabIndex = 36;
            inStockLabel.Text = "In Stock:";
            // 
            // skuLabel
            // 
            skuLabel.AutoSize = true;
            skuLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            skuLabel.Location = new System.Drawing.Point(12, 267);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new System.Drawing.Size(66, 34);
            skuLabel.TabIndex = 38;
            skuLabel.Text = "Sku:";
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F);
            partsLabel.Location = new System.Drawing.Point(12, 343);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new System.Drawing.Size(83, 34);
            partsLabel.TabIndex = 39;
            partsLabel.Text = "Parts:";
            // 
            // inventoryIDTextBox
            // 
            this.inventoryIDTextBox.Location = new System.Drawing.Point(212, 75);
            this.inventoryIDTextBox.Name = "inventoryIDTextBox";
            this.inventoryIDTextBox.ReadOnly = true;
            this.inventoryIDTextBox.Size = new System.Drawing.Size(140, 20);
            this.inventoryIDTextBox.TabIndex = 24;
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(391, 116);
            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(397, 158);
            this.itemDescriptionTextBox.TabIndex = 26;
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.Location = new System.Drawing.Point(212, 148);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(140, 20);
            this.vendorTextBox.TabIndex = 28;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(212, 116);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.itemNameTextBox.TabIndex = 30;
            // 
            // itemCostTextBox
            // 
            this.itemCostTextBox.Location = new System.Drawing.Point(212, 195);
            this.itemCostTextBox.Name = "itemCostTextBox";
            this.itemCostTextBox.Size = new System.Drawing.Size(140, 20);
            this.itemCostTextBox.TabIndex = 32;
            // 
            // itemMarkUpTextBox
            // 
            this.itemMarkUpTextBox.Location = new System.Drawing.Point(212, 237);
            this.itemMarkUpTextBox.Name = "itemMarkUpTextBox";
            this.itemMarkUpTextBox.Size = new System.Drawing.Size(140, 20);
            this.itemMarkUpTextBox.TabIndex = 34;
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(212, 279);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(140, 20);
            this.skuTextBox.TabIndex = 35;
            // 
            // inStockTextBox
            // 
            this.inStockTextBox.Location = new System.Drawing.Point(212, 321);
            this.inStockTextBox.Name = "inStockTextBox";
            this.inStockTextBox.Size = new System.Drawing.Size(140, 20);
            this.inStockTextBox.TabIndex = 37;
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
            // shopInventoryBindingNavigator
            // 
            this.shopInventoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shopInventoryBindingNavigator.BindingSource = this.shopInventoryBindingSource;
            this.shopInventoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shopInventoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shopInventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.shopInventoryBindingNavigatorSaveItem});
            this.shopInventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shopInventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shopInventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shopInventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shopInventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shopInventoryBindingNavigator.Name = "shopInventoryBindingNavigator";
            this.shopInventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shopInventoryBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.shopInventoryBindingNavigator.TabIndex = 39;
            this.shopInventoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // shopInventoryBindingNavigatorSaveItem
            // 
            this.shopInventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shopInventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shopInventoryBindingNavigatorSaveItem.Image")));
            this.shopInventoryBindingNavigatorSaveItem.Name = "shopInventoryBindingNavigatorSaveItem";
            this.shopInventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.shopInventoryBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // partsRadioButton
            // 
            this.partsRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.shopInventoryBindingSource, "Parts", true));
            this.partsRadioButton.Location = new System.Drawing.Point(212, 353);
            this.partsRadioButton.Name = "partsRadioButton";
            this.partsRadioButton.Size = new System.Drawing.Size(104, 24);
            this.partsRadioButton.TabIndex = 40;
            this.partsRadioButton.TabStop = true;
            this.partsRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 44);
            this.button1.TabIndex = 41;
            this.button1.Text = "&Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PartsInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(partsLabel);
            this.Controls.Add(this.partsRadioButton);
            this.Controls.Add(this.shopInventoryBindingNavigator);
            this.Controls.Add(skuLabel);
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
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(inStockLabel);
            this.Controls.Add(this.inStockTextBox);
            this.Name = "PartsInv";
            this.Text = "PartsInv";
            this.Load += new System.EventHandler(this.PartsInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingNavigator)).EndInit();
            this.shopInventoryBindingNavigator.ResumeLayout(false);
            this.shopInventoryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inventoryIDTextBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox vendorTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemCostTextBox;
        private System.Windows.Forms.TextBox itemMarkUpTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.TextBox inStockTextBox;
        private ShopInventory shopInventory;
        private System.Windows.Forms.BindingSource shopInventoryBindingSource;
        private ShopInventoryTableAdapters.ShopInventoryTableAdapter shopInventoryTableAdapter;
        private ShopInventoryTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator shopInventoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton shopInventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.RadioButton partsRadioButton;
        private System.Windows.Forms.Button button1;
    }
}