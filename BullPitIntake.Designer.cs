namespace CodysShop
{
    partial class BullPitIntake
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
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label vinLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label yearLabel1;
            System.Windows.Forms.Label totaledLabel;
            System.Windows.Forms.Label partsLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.wrekerIntakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet1 = new CodysShop.ShopDataSet1();
            this.wrekerIntakeTableAdapter = new CodysShop.ShopDataSet1TableAdapters.WrekerIntakeTableAdapter();
            this.tableAdapterManager = new CodysShop.ShopDataSet1TableAdapters.TableAdapterManager();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.shopDataSet = new CodysShop.ShopDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new CodysShop.ShopDataSetTableAdapters.CustomersTableAdapter();
            this.totaledComboBox = new System.Windows.Forms.ComboBox();
            this.partsComboBox = new System.Windows.Forms.ComboBox();
            locationLabel = new System.Windows.Forms.Label();
            vinLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            yearLabel1 = new System.Windows.Forms.Label();
            totaledLabel = new System.Windows.Forms.Label();
            partsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrekerIntakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.Location = new System.Drawing.Point(542, 12);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(108, 30);
            locationLabel.TabIndex = 29;
            locationLabel.Text = "Location:";
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vinLabel.Location = new System.Drawing.Point(341, 45);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new System.Drawing.Size(51, 30);
            vinLabel.TabIndex = 27;
            vinLabel.Text = "Vin:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelLabel.Location = new System.Drawing.Point(309, 10);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(83, 30);
            modelLabel.TabIndex = 25;
            modelLabel.Text = "Model:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            makeLabel.Location = new System.Drawing.Point(43, 45);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(77, 30);
            makeLabel.TabIndex = 23;
            makeLabel.Text = "Make:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            idLabel.Location = new System.Drawing.Point(684, 17);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(38, 30);
            idLabel.TabIndex = 17;
            idLabel.Text = "Id:";
            // 
            // yearLabel1
            // 
            yearLabel1.AutoSize = true;
            yearLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yearLabel1.Location = new System.Drawing.Point(54, 11);
            yearLabel1.Name = "yearLabel1";
            yearLabel1.Size = new System.Drawing.Size(66, 30);
            yearLabel1.TabIndex = 30;
            yearLabel1.Text = "Year:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 67);
            this.panel1.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(13, 24);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(740, 24);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 18;
            // 
            // wrekerIntakeBindingSource
            // 
            this.wrekerIntakeBindingSource.DataMember = "WrekerIntake";
            this.wrekerIntakeBindingSource.DataSource = this.shopDataSet1;
            // 
            // shopDataSet1
            // 
            this.shopDataSet1.DataSetName = "ShopDataSet1";
            this.shopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wrekerIntakeTableAdapter
            // 
            this.wrekerIntakeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CodysShop.ShopDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WrekerIntakeTableAdapter = this.wrekerIntakeTableAdapter;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(656, 17);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 30;
            // 
            // vinTextBox
            // 
            this.vinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Vin", true));
            this.vinTextBox.Location = new System.Drawing.Point(398, 54);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.Size = new System.Drawing.Size(100, 20);
            this.vinTextBox.TabIndex = 28;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(398, 17);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 26;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(126, 54);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 67);
            this.button1.TabIndex = 31;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(partsLabel);
            this.panel3.Controls.Add(this.partsComboBox);
            this.panel3.Controls.Add(totaledLabel);
            this.panel3.Controls.Add(this.totaledComboBox);
            this.panel3.Controls.Add(yearLabel1);
            this.panel3.Controls.Add(this.yearTextBox);
            this.panel3.Controls.Add(this.makeTextBox);
            this.panel3.Controls.Add(locationLabel);
            this.panel3.Controls.Add(this.locationTextBox);
            this.panel3.Controls.Add(vinLabel);
            this.panel3.Controls.Add(makeLabel);
            this.panel3.Controls.Add(this.vinTextBox);
            this.panel3.Controls.Add(this.modelTextBox);
            this.panel3.Controls.Add(modelLabel);
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 352);
            this.panel3.TabIndex = 33;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(126, 16);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 31;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.shopDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // totaledLabel
            // 
            totaledLabel.AutoSize = true;
            totaledLabel.Location = new System.Drawing.Point(272, 131);
            totaledLabel.Name = "totaledLabel";
            totaledLabel.Size = new System.Drawing.Size(46, 13);
            totaledLabel.TabIndex = 31;
            totaledLabel.Text = "Totaled:";
            // 
            // totaledComboBox
            // 
            this.totaledComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Totaled", true));
            this.totaledComboBox.FormattingEnabled = true;
            this.totaledComboBox.Location = new System.Drawing.Point(324, 128);
            this.totaledComboBox.Name = "totaledComboBox";
            this.totaledComboBox.Size = new System.Drawing.Size(121, 21);
            this.totaledComboBox.TabIndex = 32;
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Location = new System.Drawing.Point(485, 128);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new System.Drawing.Size(34, 13);
            partsLabel.TabIndex = 32;
            partsLabel.Text = "Parts:";
            // 
            // partsComboBox
            // 
            this.partsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Parts", true));
            this.partsComboBox.FormattingEnabled = true;
            this.partsComboBox.Location = new System.Drawing.Point(525, 125);
            this.partsComboBox.Name = "partsComboBox";
            this.partsComboBox.Size = new System.Drawing.Size(121, 21);
            this.partsComboBox.TabIndex = 33;
            // 
            // BullPitIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "BullPitIntake";
            this.Text = "BullPitIntake";
            this.Load += new System.EventHandler(this.BullPitIntake_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrekerIntakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private ShopDataSet1 shopDataSet1;
        private System.Windows.Forms.BindingSource wrekerIntakeBindingSource;
        private ShopDataSet1TableAdapters.WrekerIntakeTableAdapter wrekerIntakeTableAdapter;
        private ShopDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox yearTextBox;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ShopDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.ComboBox partsComboBox;
        private System.Windows.Forms.ComboBox totaledComboBox;
    }
}