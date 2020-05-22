namespace CodysShop
{
    partial class ReviewCustomer
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
            System.Windows.Forms.Label customerIDLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new CodysShop.ShopDataSet();
            this.customersTableAdapter = new CodysShop.ShopDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new CodysShop.ShopDataSetTableAdapters.TableAdapterManager();
            this.phoneToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.phoneToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByPhoneToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByPhoneToolStrip = new System.Windows.Forms.ToolStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            customerIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.fillByPhoneToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIDLabel.Location = new System.Drawing.Point(584, 14);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(167, 34);
            customerIDLabel.TabIndex = 0;
            customerIDLabel.Text = "Customer ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(customerIDLabel);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.customerIDTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 67);
            this.panel1.TabIndex = 2;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(13, 24);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(759, 24);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 1;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = CodysShop.ShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // phoneToolStripLabel
            // 
            this.phoneToolStripLabel.Name = "phoneToolStripLabel";
            this.phoneToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.phoneToolStripLabel.Text = "phone:";
            // 
            // phoneToolStripTextBox
            // 
            this.phoneToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneToolStripTextBox.Name = "phoneToolStripTextBox";
            this.phoneToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByPhoneToolStripButton
            // 
            this.fillByPhoneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByPhoneToolStripButton.Name = "fillByPhoneToolStripButton";
            this.fillByPhoneToolStripButton.Size = new System.Drawing.Size(73, 22);
            this.fillByPhoneToolStripButton.Text = "FillByPhone";
            this.fillByPhoneToolStripButton.Click += new System.EventHandler(this.fillByPhoneToolStripButton_Click);
            // 
            // fillByPhoneToolStrip
            // 
            this.fillByPhoneToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phoneToolStripLabel,
            this.phoneToolStripTextBox,
            this.fillByPhoneToolStripButton});
            this.fillByPhoneToolStrip.Location = new System.Drawing.Point(0, 67);
            this.fillByPhoneToolStrip.Name = "fillByPhoneToolStrip";
            this.fillByPhoneToolStrip.Size = new System.Drawing.Size(874, 25);
            this.fillByPhoneToolStrip.TabIndex = 5;
            this.fillByPhoneToolStrip.Text = "fillByPhoneToolStrip";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 95);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(874, 286);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CustomerID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FirstName";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LastName";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Make";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Model";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phone";
            this.columnHeader7.Width = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReviewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fillByPhoneToolStrip);
            this.Controls.Add(this.panel1);
            this.Name = "ReviewCustomer";
            this.Text = "ReviewCustomer";
            this.Load += new System.EventHandler(this.ReviewCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.fillByPhoneToolStrip.ResumeLayout(false);
            this.fillByPhoneToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ShopDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private ShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.ToolStripLabel phoneToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox phoneToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByPhoneToolStripButton;
        private System.Windows.Forms.ToolStrip fillByPhoneToolStrip;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button1;
    }
}