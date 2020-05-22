namespace CodysShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagment));
            System.Windows.Forms.Label inventoryIDLabel;
            System.Windows.Forms.Label itemDescriptionLabel;
            System.Windows.Forms.Label dateLabel;
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
            this.shopInventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.shopInventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.shopInventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryIDTextBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.vendorTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemCostTextBox = new System.Windows.Forms.TextBox();
            this.itemMarkUpTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.inStockTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.shopTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            inventoryIDLabel = new System.Windows.Forms.Label();
            itemDescriptionLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingNavigator)).BeginInit();
            this.shopInventoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 51);
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
            this.shopInventoryBindingNavigator.Location = new System.Drawing.Point(0, 51);
            this.shopInventoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shopInventoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shopInventoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shopInventoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shopInventoryBindingNavigator.Name = "shopInventoryBindingNavigator";
            this.shopInventoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shopInventoryBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.shopInventoryBindingNavigator.TabIndex = 1;
            this.shopInventoryBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // shopInventoryBindingNavigatorSaveItem
            // 
            this.shopInventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shopInventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shopInventoryBindingNavigatorSaveItem.Image")));
            this.shopInventoryBindingNavigatorSaveItem.Name = "shopInventoryBindingNavigatorSaveItem";
            this.shopInventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.shopInventoryBindingNavigatorSaveItem.Text = "Save Data";
            this.shopInventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.shopInventoryBindingNavigatorSaveItem_Click);
            // 
            // shopInventoryDataGridView
            // 
            this.shopInventoryDataGridView.AutoGenerateColumns = false;
            this.shopInventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopInventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.shopInventoryDataGridView.DataSource = this.shopInventoryBindingSource;
            this.shopInventoryDataGridView.Location = new System.Drawing.Point(0, 79);
            this.shopInventoryDataGridView.Name = "shopInventoryDataGridView";
            this.shopInventoryDataGridView.Size = new System.Drawing.Size(800, 87);
            this.shopInventoryDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InventoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "InventoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemDescription";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vendor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vendor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn5.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemCost";
            this.dataGridViewTextBoxColumn6.HeaderText = "ItemCost";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ItemMarkUp";
            this.dataGridViewTextBoxColumn7.HeaderText = "ItemMarkUp";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Sku";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sku";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "InStock";
            this.dataGridViewTextBoxColumn9.HeaderText = "InStock";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Parts";
            this.dataGridViewTextBoxColumn10.HeaderText = "Parts";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Shop";
            this.dataGridViewTextBoxColumn11.HeaderText = "Shop";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // inventoryIDLabel
            // 
            inventoryIDLabel.AutoSize = true;
            inventoryIDLabel.Location = new System.Drawing.Point(167, 216);
            inventoryIDLabel.Name = "inventoryIDLabel";
            inventoryIDLabel.Size = new System.Drawing.Size(68, 13);
            inventoryIDLabel.TabIndex = 3;
            inventoryIDLabel.Text = "Inventory ID:";
            // 
            // inventoryIDTextBox
            // 
            this.inventoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "InventoryID", true));
            this.inventoryIDTextBox.Location = new System.Drawing.Point(259, 213);
            this.inventoryIDTextBox.Name = "inventoryIDTextBox";
            this.inventoryIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryIDTextBox.TabIndex = 4;
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Location = new System.Drawing.Point(167, 242);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new System.Drawing.Size(86, 13);
            itemDescriptionLabel.TabIndex = 5;
            itemDescriptionLabel.Text = "Item Description:";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemDescription", true));
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(259, 239);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemDescriptionTextBox.TabIndex = 6;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(167, 268);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Date:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(259, 265);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 8;
            // 
            // vendorLabel
            // 
            vendorLabel.AutoSize = true;
            vendorLabel.Location = new System.Drawing.Point(167, 294);
            vendorLabel.Name = "vendorLabel";
            vendorLabel.Size = new System.Drawing.Size(44, 13);
            vendorLabel.TabIndex = 9;
            vendorLabel.Text = "Vendor:";
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "Vendor", true));
            this.vendorTextBox.Location = new System.Drawing.Point(259, 291);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorTextBox.TabIndex = 10;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(167, 320);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(61, 13);
            itemNameLabel.TabIndex = 11;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(259, 317);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNameTextBox.TabIndex = 12;
            // 
            // itemCostLabel
            // 
            itemCostLabel.AutoSize = true;
            itemCostLabel.Location = new System.Drawing.Point(167, 346);
            itemCostLabel.Name = "itemCostLabel";
            itemCostLabel.Size = new System.Drawing.Size(54, 13);
            itemCostLabel.TabIndex = 13;
            itemCostLabel.Text = "Item Cost:";
            // 
            // itemCostTextBox
            // 
            this.itemCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemCost", true));
            this.itemCostTextBox.Location = new System.Drawing.Point(259, 343);
            this.itemCostTextBox.Name = "itemCostTextBox";
            this.itemCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemCostTextBox.TabIndex = 14;
            // 
            // itemMarkUpLabel
            // 
            itemMarkUpLabel.AutoSize = true;
            itemMarkUpLabel.Location = new System.Drawing.Point(167, 372);
            itemMarkUpLabel.Name = "itemMarkUpLabel";
            itemMarkUpLabel.Size = new System.Drawing.Size(74, 13);
            itemMarkUpLabel.TabIndex = 15;
            itemMarkUpLabel.Text = "Item Mark Up:";
            // 
            // itemMarkUpTextBox
            // 
            this.itemMarkUpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "ItemMarkUp", true));
            this.itemMarkUpTextBox.Location = new System.Drawing.Point(259, 369);
            this.itemMarkUpTextBox.Name = "itemMarkUpTextBox";
            this.itemMarkUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemMarkUpTextBox.TabIndex = 16;
            // 
            // skuLabel
            // 
            skuLabel.AutoSize = true;
            skuLabel.Location = new System.Drawing.Point(167, 398);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new System.Drawing.Size(29, 13);
            skuLabel.TabIndex = 17;
            skuLabel.Text = "Sku:";
            // 
            // skuTextBox
            // 
            this.skuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "Sku", true));
            this.skuTextBox.Location = new System.Drawing.Point(259, 395);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(100, 20);
            this.skuTextBox.TabIndex = 18;
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Location = new System.Drawing.Point(167, 424);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new System.Drawing.Size(50, 13);
            inStockLabel.TabIndex = 19;
            inStockLabel.Text = "In Stock:";
            // 
            // inStockTextBox
            // 
            this.inStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "InStock", true));
            this.inStockTextBox.Location = new System.Drawing.Point(259, 421);
            this.inStockTextBox.Name = "inStockTextBox";
            this.inStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.inStockTextBox.TabIndex = 20;
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Location = new System.Drawing.Point(167, 450);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new System.Drawing.Size(34, 13);
            partsLabel.TabIndex = 21;
            partsLabel.Text = "Parts:";
            // 
            // partsTextBox
            // 
            this.partsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "Parts", true));
            this.partsTextBox.Location = new System.Drawing.Point(259, 447);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTextBox.TabIndex = 22;
            // 
            // shopLabel
            // 
            shopLabel.AutoSize = true;
            shopLabel.Location = new System.Drawing.Point(167, 476);
            shopLabel.Name = "shopLabel";
            shopLabel.Size = new System.Drawing.Size(35, 13);
            shopLabel.TabIndex = 23;
            shopLabel.Text = "Shop:";
            // 
            // shopTextBox
            // 
            this.shopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shopInventoryBindingSource, "Shop", true));
            this.shopTextBox.Location = new System.Drawing.Point(259, 473);
            this.shopTextBox.Name = "shopTextBox";
            this.shopTextBox.Size = new System.Drawing.Size(100, 20);
            this.shopTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InventoryManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(inventoryIDLabel);
            this.Controls.Add(this.inventoryIDTextBox);
            this.Controls.Add(itemDescriptionLabel);
            this.Controls.Add(this.itemDescriptionTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
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
            this.Controls.Add(partsLabel);
            this.Controls.Add(this.partsTextBox);
            this.Controls.Add(shopLabel);
            this.Controls.Add(this.shopTextBox);
            this.Controls.Add(this.shopInventoryDataGridView);
            this.Controls.Add(this.shopInventoryBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryManagment";
            this.Text = "InventoryManagment";
            this.Load += new System.EventHandler(this.InventoryManagment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryBindingNavigator)).EndInit();
            this.shopInventoryBindingNavigator.ResumeLayout(false);
            this.shopInventoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopInventoryDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView shopInventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox inventoryIDTextBox;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox vendorTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemCostTextBox;
        private System.Windows.Forms.TextBox itemMarkUpTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.TextBox inStockTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.TextBox shopTextBox;
        private System.Windows.Forms.Button button1;
    }
}