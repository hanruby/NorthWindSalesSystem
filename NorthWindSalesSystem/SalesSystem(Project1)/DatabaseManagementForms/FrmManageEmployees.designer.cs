namespace SalesSystem.DatabaseManagmentForms
{
    partial class FrmManageEmployees
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
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
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
            this.txtCourtasy = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCourtasy = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.lblManageEmployees = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(459, 314);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(97, 23);
            this.btnCloseWindow.TabIndex = 16;
            this.btnCloseWindow.Text = "Cancel";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(272, 314);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(101, 23);
            this.btnSaveChanges.TabIndex = 15;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(335, 201);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(51, 20);
            this.txtExtension.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(80, 203);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(268, 206);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(56, 13);
            this.lblExtension.TabIndex = 47;
            this.lblExtension.Text = "Extension:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(5, 203);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(72, 13);
            this.lblPhone.TabIndex = 46;
            this.lblPhone.Text = "Home Phone:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(481, 173);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(82, 20);
            this.txtCountry.TabIndex = 11;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(335, 172);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(73, 20);
            this.txtPostalCode.TabIndex = 10;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(79, 173);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(125, 20);
            this.txtRegion.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(414, 175);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 42;
            this.lblCountry.Text = "Country:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(262, 175);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 41;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(5, 176);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 40;
            this.lblRegion.Text = "Region:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(335, 143);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(79, 143);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(125, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(270, 149);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 149);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 36;
            this.lblCity.Text = "City:";
            // 
            // txtCourtasy
            // 
            this.txtCourtasy.Location = new System.Drawing.Point(335, 85);
            this.txtCourtasy.Name = "txtCourtasy";
            this.txtCourtasy.Size = new System.Drawing.Size(48, 20);
            this.txtCourtasy.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(79, 85);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(125, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblCourtasy
            // 
            this.lblCourtasy.AutoSize = true;
            this.lblCourtasy.Location = new System.Drawing.Point(270, 88);
            this.lblCourtasy.Name = "lblCourtasy";
            this.lblCourtasy.Size = new System.Drawing.Size(51, 13);
            this.lblCourtasy.TabIndex = 33;
            this.lblCourtasy.Text = "Courtasy:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Title:";
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(335, 38);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(232, 21);
            this.cmbEmployeeName.TabIndex = 2;
            this.cmbEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeName_SelectedIndexChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(242, 46);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(87, 13);
            this.lblEmployeeName.TabIndex = 30;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(5, 41);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeID.TabIndex = 29;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(80, 38);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(50, 21);
            this.cmbEmployeeID.TabIndex = 1;
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            // 
            // lblManageEmployees
            // 
            this.lblManageEmployees.AutoSize = true;
            this.lblManageEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmployees.Location = new System.Drawing.Point(5, 9);
            this.lblManageEmployees.Name = "lblManageEmployees";
            this.lblManageEmployees.Size = new System.Drawing.Size(165, 20);
            this.lblManageEmployees.TabIndex = 27;
            this.lblManageEmployees.Text = "Manage Employees";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 118);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(57, 13);
            this.lblBirthDate.TabIndex = 54;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(269, 118);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(55, 13);
            this.lblHireDate.TabIndex = 55;
            this.lblHireDate.Text = "Hire Date:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(79, 114);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(185, 20);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(335, 114);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(228, 20);
            this.dtpHireDate.TabIndex = 6;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(6, 253);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 58;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(80, 230);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(483, 78);
            this.txtNotes.TabIndex = 14;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Location = new System.Drawing.Point(12, 314);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(96, 23);
            this.btnNewEmployee.TabIndex = 59;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(485, 64);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(82, 20);
            this.txtLName.TabIndex = 61;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(335, 64);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(83, 20);
            this.txtFName.TabIndex = 60;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(418, 67);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 63;
            this.lblLName.Text = "Last Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(257, 67);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(60, 13);
            this.lblFname.TabIndex = 62;
            this.lblFname.Text = "First Name:";
            // 
            // FrmManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 347);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblExtension);
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
            this.Controls.Add(this.txtCourtasy);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblCourtasy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbEmployeeName);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.cmbEmployeeID);
            this.Controls.Add(this.lblManageEmployees);
            this.Name = "FrmManageEmployees";
            this.Text = "FrmManageEmployees";
            this.Load += new System.EventHandler(this.FrmManageEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblExtension;
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
        private System.Windows.Forms.TextBox txtCourtasy;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblCourtasy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.Label lblManageEmployees;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFname;
    }
}