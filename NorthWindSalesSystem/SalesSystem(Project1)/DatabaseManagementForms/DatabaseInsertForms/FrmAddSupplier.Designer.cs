namespace SalesSystem.DatabaseManagmentForms.DatabaseInsertForms
{
    partial class FrmAddSupplier
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblAddSuppliers = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(440, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Location = new System.Drawing.Point(341, 199);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(93, 23);
            this.btnNewSupplier.TabIndex = 39;
            this.btnNewSupplier.Text = "Add Supplier";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(323, 162);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(122, 20);
            this.txtFax.TabIndex = 55;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 162);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(126, 20);
            this.txtPhone.TabIndex = 53;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(229, 165);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 13);
            this.lblFax.TabIndex = 64;
            this.lblFax.Text = "Fax:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(27, 165);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 63;
            this.lblPhone.Text = "Phone:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(449, 136);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(97, 20);
            this.txtCountry.TabIndex = 51;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(323, 136);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(70, 20);
            this.txtPostalCode.TabIndex = 49;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(95, 136);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(125, 20);
            this.txtRegion.TabIndex = 47;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(399, 139);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 62;
            this.lblCountry.Text = "Country:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(229, 139);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 61;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(27, 139);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 60;
            this.lblRegion.Text = "Region:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(323, 108);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(223, 20);
            this.txtAddress.TabIndex = 46;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(95, 108);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(125, 20);
            this.txtCity.TabIndex = 45;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(229, 111);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 59;
            this.lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(27, 111);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 58;
            this.lblCity.Text = "City:";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(323, 80);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(223, 20);
            this.txtContactName.TabIndex = 43;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(96, 80);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(125, 20);
            this.txtTitle.TabIndex = 42;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(229, 83);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(78, 13);
            this.lblContactName.TabIndex = 54;
            this.lblContactName.Text = "Contact Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(27, 83);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 13);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Contact Title:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(12, 54);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 50;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // lblAddSuppliers
            // 
            this.lblAddSuppliers.AutoSize = true;
            this.lblAddSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSuppliers.Location = new System.Drawing.Point(14, 11);
            this.lblAddSuppliers.Name = "lblAddSuppliers";
            this.lblAddSuppliers.Size = new System.Drawing.Size(121, 20);
            this.lblAddSuppliers.TabIndex = 44;
            this.lblAddSuppliers.Text = "Add Suppliers";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(96, 51);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(450, 20);
            this.txtCompanyName.TabIndex = 65;
            // 
            // FrmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 239);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblAddSuppliers);
            this.Name = "FrmAddSupplier";
            this.Text = "FrmAddSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblAddSuppliers;
        private System.Windows.Forms.TextBox txtCompanyName;

    }
}