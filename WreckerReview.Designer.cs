namespace CodysShop
{
    partial class WreckerReview
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label totaledLabel;
            System.Windows.Forms.Label partsLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label vinLabel;
            System.Windows.Forms.Label locationLabel;
            this.shopDataSet1 = new CodysShop.ShopDataSet1();
            this.wrekerIntakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wrekerIntakeTableAdapter = new CodysShop.ShopDataSet1TableAdapters.WrekerIntakeTableAdapter();
            this.tableAdapterManager = new CodysShop.ShopDataSet1TableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.totaledTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            totaledLabel = new System.Windows.Forms.Label();
            partsLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            vinLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrekerIntakeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            idLabel.Location = new System.Drawing.Point(648, 12);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(34, 26);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // totaledLabel
            // 
            totaledLabel.AutoSize = true;
            totaledLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            totaledLabel.Location = new System.Drawing.Point(446, 100);
            totaledLabel.Name = "totaledLabel";
            totaledLabel.Size = new System.Drawing.Size(83, 26);
            totaledLabel.TabIndex = 3;
            totaledLabel.Text = "Totaled:";
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            partsLabel.Location = new System.Drawing.Point(462, 46);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new System.Drawing.Size(65, 26);
            partsLabel.TabIndex = 5;
            partsLabel.Text = "Parts:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            yearLabel.Location = new System.Drawing.Point(6, 46);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(57, 26);
            yearLabel.TabIndex = 7;
            yearLabel.Text = "Year:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            makeLabel.Location = new System.Drawing.Point(231, 43);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(67, 26);
            makeLabel.TabIndex = 9;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            modelLabel.Location = new System.Drawing.Point(3, 94);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(72, 26);
            modelLabel.TabIndex = 11;
            modelLabel.Text = "Model:";
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            vinLabel.Location = new System.Drawing.Point(247, 94);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new System.Drawing.Size(44, 26);
            vinLabel.TabIndex = 13;
            vinLabel.Text = "Vin:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            locationLabel.Location = new System.Drawing.Point(205, 152);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(93, 26);
            locationLabel.TabIndex = 15;
            locationLabel.Text = "Location:";
            // 
            // shopDataSet1
            // 
            this.shopDataSet1.DataSetName = "ShopDataSet1";
            this.shopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wrekerIntakeBindingSource
            // 
            this.wrekerIntakeBindingSource.DataMember = "WrekerIntake";
            this.wrekerIntakeBindingSource.DataSource = this.shopDataSet1;
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
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(688, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // totaledTextBox
            // 
            this.totaledTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Totaled", true));
            this.totaledTextBox.Location = new System.Drawing.Point(545, 100);
            this.totaledTextBox.Name = "totaledTextBox";
            this.totaledTextBox.ReadOnly = true;
            this.totaledTextBox.Size = new System.Drawing.Size(100, 20);
            this.totaledTextBox.TabIndex = 4;
            // 
            // partsTextBox
            // 
            this.partsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Parts", true));
            this.partsTextBox.Location = new System.Drawing.Point(545, 52);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.ReadOnly = true;
            this.partsTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(81, 52);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 8;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(304, 49);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.ReadOnly = true;
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 10;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(81, 100);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 12;
            // 
            // vinTextBox
            // 
            this.vinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Vin", true));
            this.vinTextBox.Location = new System.Drawing.Point(304, 100);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.ReadOnly = true;
            this.vinTextBox.Size = new System.Drawing.Size(100, 20);
            this.vinTextBox.TabIndex = 14;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wrekerIntakeBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(304, 158);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(654, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WreckerReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(totaledLabel);
            this.Controls.Add(this.totaledTextBox);
            this.Controls.Add(partsLabel);
            this.Controls.Add(this.partsTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(vinLabel);
            this.Controls.Add(this.vinTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Name = "WreckerReview";
            this.Text = "WreckerReview";
            this.Load += new System.EventHandler(this.WreckerReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrekerIntakeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShopDataSet1 shopDataSet1;
        private System.Windows.Forms.BindingSource wrekerIntakeBindingSource;
        private ShopDataSet1TableAdapters.WrekerIntakeTableAdapter wrekerIntakeTableAdapter;
        private ShopDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox totaledTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button button1;
    }
}