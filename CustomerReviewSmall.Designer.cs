namespace CodysShop
{
    partial class CustomerReviewSmall
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.shopDataSet = new CodysShop.ShopDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new CodysShop.ShopDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new CodysShop.ShopDataSetTableAdapters.TableAdapterManager();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtComplaints = new System.Windows.Forms.TextBox();
            this.txtRepairs = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(613, 482);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "&Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
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
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIDLabel.Location = new System.Drawing.Point(13, 13);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(129, 26);
            customerIDLabel.TabIndex = 2;
            customerIDLabel.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.txtCustomerID.Location = new System.Drawing.Point(156, 19);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(26, 39);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(116, 26);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(156, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(28, 65);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(114, 26);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(156, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(68, 91);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(74, 26);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Phone:";
            // 
            // txtEhone
            // 
            this.txtEhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.txtEhone.Location = new System.Drawing.Point(156, 97);
            this.txtEhone.Name = "txtEhone";
            this.txtEhone.Size = new System.Drawing.Size(100, 20);
            this.txtEhone.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(75, 117);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(67, 26);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(156, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            streetLabel.Location = new System.Drawing.Point(353, 13);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(72, 26);
            streetLabel.TabIndex = 12;
            streetLabel.Text = "Street:";
            // 
            // txtStreet
            // 
            this.txtStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Street", true));
            this.txtStreet.Location = new System.Drawing.Point(433, 19);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 13;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitLabel.Location = new System.Drawing.Point(373, 39);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(52, 26);
            unitLabel.TabIndex = 14;
            unitLabel.Text = "Unit:";
            // 
            // txtUnit
            // 
            this.txtUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Unit", true));
            this.txtUnit.Location = new System.Drawing.Point(433, 45);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 15;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(373, 65);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(50, 26);
            cityLabel.TabIndex = 16;
            cityLabel.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.txtCity.Location = new System.Drawing.Point(433, 71);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 17;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(360, 91);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(65, 26);
            stateLabel.TabIndex = 18;
            stateLabel.Text = "State:";
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.txtState.Location = new System.Drawing.Point(433, 97);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 19;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipLabel.Location = new System.Drawing.Point(381, 117);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(44, 26);
            zipLabel.TabIndex = 20;
            zipLabel.Text = "Zip:";
            // 
            // txtZip
            // 
            this.txtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Zip", true));
            this.txtZip.Location = new System.Drawing.Point(433, 123);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 21;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yearLabel.Location = new System.Drawing.Point(93, 165);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(57, 26);
            yearLabel.TabIndex = 22;
            yearLabel.Text = "Year:";
            // 
            // txtYear
            // 
            this.txtYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Year", true));
            this.txtYear.Location = new System.Drawing.Point(156, 171);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 23;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            makeLabel.Location = new System.Drawing.Point(83, 191);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(67, 26);
            makeLabel.TabIndex = 24;
            makeLabel.Text = "Make:";
            // 
            // txtMake
            // 
            this.txtMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Make", true));
            this.txtMake.Location = new System.Drawing.Point(156, 197);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 25;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelLabel.Location = new System.Drawing.Point(78, 217);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(72, 26);
            modelLabel.TabIndex = 26;
            modelLabel.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Model", true));
            this.txtModel.Location = new System.Drawing.Point(156, 223);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 27;
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vinLabel.Location = new System.Drawing.Point(106, 243);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new System.Drawing.Size(44, 26);
            vinLabel.TabIndex = 28;
            vinLabel.Text = "Vin:";
            // 
            // txtVin
            // 
            this.txtVin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Vin", true));
            this.txtVin.Location = new System.Drawing.Point(156, 249);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(100, 20);
            this.txtVin.TabIndex = 29;
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mileageLabel.Location = new System.Drawing.Point(62, 269);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(88, 26);
            mileageLabel.TabIndex = 30;
            mileageLabel.Text = "Mileage:";
            // 
            // txtMileage
            // 
            this.txtMileage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Mileage", true));
            this.txtMileage.Location = new System.Drawing.Point(156, 275);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(100, 20);
            this.txtMileage.TabIndex = 31;
            // 
            // licensePlateLabel
            // 
            licensePlateLabel.AutoSize = true;
            licensePlateLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            licensePlateLabel.Location = new System.Drawing.Point(13, 295);
            licensePlateLabel.Name = "licensePlateLabel";
            licensePlateLabel.Size = new System.Drawing.Size(137, 26);
            licensePlateLabel.TabIndex = 32;
            licensePlateLabel.Text = "License Plate:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "LicensePlate", true));
            this.txtLicensePlate.Location = new System.Drawing.Point(156, 301);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(100, 20);
            this.txtLicensePlate.TabIndex = 33;
            // 
            // complaintsLabel
            // 
            complaintsLabel.AutoSize = true;
            complaintsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            complaintsLabel.Location = new System.Drawing.Point(302, 165);
            complaintsLabel.Name = "complaintsLabel";
            complaintsLabel.Size = new System.Drawing.Size(116, 26);
            complaintsLabel.TabIndex = 34;
            complaintsLabel.Text = "complaints:";
            // 
            // txtComplaints
            // 
            this.txtComplaints.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "complaints", true));
            this.txtComplaints.Location = new System.Drawing.Point(433, 171);
            this.txtComplaints.Multiline = true;
            this.txtComplaints.Name = "txtComplaints";
            this.txtComplaints.Size = new System.Drawing.Size(255, 150);
            this.txtComplaints.TabIndex = 35;
            // 
            // repairsLabel
            // 
            repairsLabel.AutoSize = true;
            repairsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            repairsLabel.Location = new System.Drawing.Point(63, 327);
            repairsLabel.Name = "repairsLabel";
            repairsLabel.Size = new System.Drawing.Size(79, 26);
            repairsLabel.TabIndex = 36;
            repairsLabel.Text = "repairs:";
            // 
            // txtRepairs
            // 
            this.txtRepairs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "repairs", true));
            this.txtRepairs.Location = new System.Drawing.Point(156, 333);
            this.txtRepairs.Multiline = true;
            this.txtRepairs.Name = "txtRepairs";
            this.txtRepairs.Size = new System.Drawing.Size(262, 137);
            this.txtRepairs.TabIndex = 37;
            // 
            // CustomerReviewSmall
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 517);
            this.ControlBox = false;
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.txtEhone);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(unitLabel);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.txtState);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(vinLabel);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(licensePlateLabel);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(complaintsLabel);
            this.Controls.Add(this.txtComplaints);
            this.Controls.Add(repairsLabel);
            this.Controls.Add(this.txtRepairs);
            this.Controls.Add(this.BtnOk);
            this.Name = "CustomerReviewSmall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.CustomerReviewSmall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ShopDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private ShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtComplaints;
        private System.Windows.Forms.TextBox txtRepairs;
    }
}