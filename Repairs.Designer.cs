namespace CodysShop
{
    partial class Repairs
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label vinLabel;
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label licensePlateLabel;
            System.Windows.Forms.Label complaintsLabel;
            System.Windows.Forms.Label repairsLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.shopDataSet = new CodysShop.ShopDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new CodysShop.ShopDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new CodysShop.ShopDataSetTableAdapters.TableAdapterManager();
            this.fillBy1lastNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lastNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1lastNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.complaintsTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.repairsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            customerIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            vinLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            licensePlateLabel = new System.Windows.Forms.Label();
            complaintsLabel = new System.Windows.Forms.Label();
            repairsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.fillBy1lastNameToolStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 3;
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
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(13, 24);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(759, 24);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 1;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = CodysShop.ShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillBy1lastNameToolStrip
            // 
            this.fillBy1lastNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastNameToolStripLabel,
            this.lastNameToolStripTextBox,
            this.fillBy1lastNameToolStripButton});
            this.fillBy1lastNameToolStrip.Location = new System.Drawing.Point(0, 67);
            this.fillBy1lastNameToolStrip.Name = "fillBy1lastNameToolStrip";
            this.fillBy1lastNameToolStrip.Size = new System.Drawing.Size(874, 25);
            this.fillBy1lastNameToolStrip.TabIndex = 5;
            this.fillBy1lastNameToolStrip.Text = "fillBy1lastNameToolStrip";
            // 
            // lastNameToolStripLabel
            // 
            this.lastNameToolStripLabel.Name = "lastNameToolStripLabel";
            this.lastNameToolStripLabel.Size = new System.Drawing.Size(63, 22);
            this.lastNameToolStripLabel.Text = "LastName:";
            // 
            // lastNameToolStripTextBox
            // 
            this.lastNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameToolStripTextBox.Name = "lastNameToolStripTextBox";
            this.lastNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy1lastNameToolStripButton
            // 
            this.fillBy1lastNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1lastNameToolStripButton.Name = "fillBy1lastNameToolStripButton";
            this.fillBy1lastNameToolStripButton.Size = new System.Drawing.Size(95, 22);
            this.fillBy1lastNameToolStripButton.Text = "FillBy1lastName";
            this.fillBy1lastNameToolStripButton.Click += new System.EventHandler(this.fillBy1lastNameToolStripButton_Click);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            firstNameLabel.Location = new System.Drawing.Point(12, 9);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(132, 30);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(174, 18);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            lastNameLabel.Location = new System.Drawing.Point(13, 47);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(131, 30);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(174, 56);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            phoneLabel.Location = new System.Drawing.Point(59, 77);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(85, 30);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(174, 86);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            emailLabel.Location = new System.Drawing.Point(67, 107);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(77, 30);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(174, 116);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            streetLabel.Location = new System.Drawing.Point(61, 137);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(83, 30);
            streetLabel.TabIndex = 15;
            streetLabel.Text = "Street:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(174, 146);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.ReadOnly = true;
            this.streetTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox.TabIndex = 16;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            unitLabel.Location = new System.Drawing.Point(84, 167);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(60, 30);
            unitLabel.TabIndex = 17;
            unitLabel.Text = "Unit:";
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(174, 176);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.ReadOnly = true;
            this.unitTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitTextBox.TabIndex = 18;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            cityLabel.Location = new System.Drawing.Point(86, 197);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(58, 30);
            cityLabel.TabIndex = 19;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(174, 207);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 20;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            stateLabel.Location = new System.Drawing.Point(69, 227);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(75, 30);
            stateLabel.TabIndex = 21;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(174, 236);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 22;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            zipLabel.Location = new System.Drawing.Point(93, 257);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(51, 30);
            zipLabel.TabIndex = 23;
            zipLabel.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(174, 266);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.ReadOnly = true;
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 24;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            yearLabel.Location = new System.Drawing.Point(518, 18);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(66, 30);
            yearLabel.TabIndex = 25;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(600, 27);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 26;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            makeLabel.Location = new System.Drawing.Point(507, 55);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(77, 30);
            makeLabel.TabIndex = 27;
            makeLabel.Text = "Make:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(600, 64);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.ReadOnly = true;
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 28;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            modelLabel.Location = new System.Drawing.Point(501, 90);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(83, 30);
            modelLabel.TabIndex = 29;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(600, 99);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 30;
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            vinLabel.Location = new System.Drawing.Point(533, 120);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new System.Drawing.Size(51, 30);
            vinLabel.TabIndex = 31;
            vinLabel.Text = "Vin:";
            // 
            // vinTextBox
            // 
            this.vinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Vin", true));
            this.vinTextBox.Location = new System.Drawing.Point(600, 129);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.ReadOnly = true;
            this.vinTextBox.Size = new System.Drawing.Size(100, 20);
            this.vinTextBox.TabIndex = 32;
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            mileageLabel.Location = new System.Drawing.Point(483, 150);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(101, 30);
            mileageLabel.TabIndex = 33;
            mileageLabel.Text = "Mileage:";
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Mileage", true));
            this.mileageTextBox.Location = new System.Drawing.Point(600, 160);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.ReadOnly = true;
            this.mileageTextBox.Size = new System.Drawing.Size(100, 20);
            this.mileageTextBox.TabIndex = 34;
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            licensePlateLabel.Location = new System.Drawing.Point(426, 186);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(158, 30);
            licensePlateLabel.TabIndex = 35;
            licensePlateLabel.Text = "License Plate:";
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LicensePlate", true));
            this.licensePlateTextBox.Location = new System.Drawing.Point(600, 196);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.ReadOnly = true;
            this.licensePlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.licensePlateTextBox.TabIndex = 36;
            // 
            // complaintsLabel
            // 
            complaintsLabel.AutoSize = true;
            complaintsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            complaintsLabel.Location = new System.Drawing.Point(451, 224);
            complaintsLabel.Name = "complaintsLabel";
            complaintsLabel.Size = new System.Drawing.Size(133, 30);
            complaintsLabel.TabIndex = 37;
            complaintsLabel.Text = "complaints:";
            // 
            // complaintsTextBox
            // 
            this.complaintsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "complaints", true));
            this.complaintsTextBox.Location = new System.Drawing.Point(600, 237);
            this.complaintsTextBox.Name = "complaintsTextBox";
            this.complaintsTextBox.ReadOnly = true;
            this.complaintsTextBox.Size = new System.Drawing.Size(100, 20);
            this.complaintsTextBox.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.unitTextBox);
            this.panel2.Controls.Add(yearLabel);
            this.panel2.Controls.Add(firstNameLabel);
            this.panel2.Controls.Add(this.yearTextBox);
            this.panel2.Controls.Add(this.zipTextBox);
            this.panel2.Controls.Add(makeLabel);
            this.panel2.Controls.Add(this.firstNameTextBox);
            this.panel2.Controls.Add(this.makeTextBox);
            this.panel2.Controls.Add(zipLabel);
            this.panel2.Controls.Add(modelLabel);
            this.panel2.Controls.Add(lastNameLabel);
            this.panel2.Controls.Add(this.modelTextBox);
            this.panel2.Controls.Add(this.stateTextBox);
            this.panel2.Controls.Add(vinLabel);
            this.panel2.Controls.Add(this.lastNameTextBox);
            this.panel2.Controls.Add(this.vinTextBox);
            this.panel2.Controls.Add(stateLabel);
            this.panel2.Controls.Add(mileageLabel);
            this.panel2.Controls.Add(phoneLabel);
            this.panel2.Controls.Add(this.mileageTextBox);
            this.panel2.Controls.Add(this.cityTextBox);
            this.panel2.Controls.Add(licensePlateLabel);
            this.panel2.Controls.Add(this.phoneTextBox);
            this.panel2.Controls.Add(this.licensePlateTextBox);
            this.panel2.Controls.Add(complaintsLabel);
            this.panel2.Controls.Add(cityLabel);
            this.panel2.Controls.Add(this.complaintsTextBox);
            this.panel2.Controls.Add(emailLabel);
            this.panel2.Controls.Add(unitLabel);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.streetTextBox);
            this.panel2.Controls.Add(streetLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 298);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.repairsTextBox);
            this.panel3.Controls.Add(repairsLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 291);
            this.panel3.TabIndex = 42;
            // 
            // repairsTextBox
            // 
            this.repairsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "repairs", true));
            this.repairsTextBox.Location = new System.Drawing.Point(174, 30);
            this.repairsTextBox.Multiline = true;
            this.repairsTextBox.Name = "repairsTextBox";
            this.repairsTextBox.Size = new System.Drawing.Size(333, 100);
            this.repairsTextBox.TabIndex = 42;
            // 
            // repairsLabel
            // 
            repairsLabel.AutoSize = true;
            repairsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            repairsLabel.Location = new System.Drawing.Point(53, 20);
            repairsLabel.Name = "repairsLabel";
            repairsLabel.Size = new System.Drawing.Size(91, 30);
            repairsLabel.TabIndex = 41;
            repairsLabel.Text = "repairs:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Repairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fillBy1lastNameToolStrip);
            this.Controls.Add(this.panel1);
            this.Name = "Repairs";
            this.Text = "Repairs";
            this.Load += new System.EventHandler(this.Repairs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.fillBy1lastNameToolStrip.ResumeLayout(false);
            this.fillBy1lastNameToolStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ShopDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private ShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillBy1lastNameToolStrip;
        private System.Windows.Forms.ToolStripLabel lastNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lastNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1lastNameToolStripButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.TextBox complaintsTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox repairsTextBox;
    }
}