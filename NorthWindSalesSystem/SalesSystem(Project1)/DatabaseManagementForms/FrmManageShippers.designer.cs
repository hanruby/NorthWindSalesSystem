namespace SalesSystem.DatabaseManagmentForms
{
    partial class FrmManageShippers
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cboShipperName = new System.Windows.Forms.ComboBox();
            this.lblShipperName = new System.Windows.Forms.Label();
            this.lblShipperID = new System.Windows.Forms.Label();
            this.cboShipperID = new System.Windows.Forms.ComboBox();
            this.lblManageShippers = new System.Windows.Forms.Label();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnNewShipper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(102, 111);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(118, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(13, 112);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 59;
            this.lblPhone.Text = "Phone:";
            // 
            // cboShipperName
            // 
            this.cboShipperName.FormattingEnabled = true;
            this.cboShipperName.Location = new System.Drawing.Point(102, 77);
            this.cboShipperName.Name = "cboShipperName";
            this.cboShipperName.Size = new System.Drawing.Size(203, 21);
            this.cboShipperName.TabIndex = 2;
            this.cboShipperName.SelectedIndexChanged += new System.EventHandler(this.cboShipperName_SelectedIndexChanged);
            // 
            // lblShipperName
            // 
            this.lblShipperName.AutoSize = true;
            this.lblShipperName.Location = new System.Drawing.Point(13, 79);
            this.lblShipperName.Name = "lblShipperName";
            this.lblShipperName.Size = new System.Drawing.Size(77, 13);
            this.lblShipperName.TabIndex = 57;
            this.lblShipperName.Text = "Shipper Name:";
            // 
            // lblShipperID
            // 
            this.lblShipperID.AutoSize = true;
            this.lblShipperID.Location = new System.Drawing.Point(12, 46);
            this.lblShipperID.Name = "lblShipperID";
            this.lblShipperID.Size = new System.Drawing.Size(60, 13);
            this.lblShipperID.TabIndex = 56;
            this.lblShipperID.Text = "Shipper ID:";
            // 
            // cboShipperID
            // 
            this.cboShipperID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShipperID.FormattingEnabled = true;
            this.cboShipperID.Location = new System.Drawing.Point(102, 43);
            this.cboShipperID.Name = "cboShipperID";
            this.cboShipperID.Size = new System.Drawing.Size(60, 21);
            this.cboShipperID.TabIndex = 1;
            this.cboShipperID.SelectedIndexChanged += new System.EventHandler(this.cboShipperID_SelectedIndexChanged);
            // 
            // lblManageShippers
            // 
            this.lblManageShippers.AutoSize = true;
            this.lblManageShippers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageShippers.Location = new System.Drawing.Point(8, 9);
            this.lblManageShippers.Name = "lblManageShippers";
            this.lblManageShippers.Size = new System.Drawing.Size(149, 20);
            this.lblManageShippers.TabIndex = 54;
            this.lblManageShippers.Text = "Manage Shippers";
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(208, 137);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(97, 23);
            this.btnCloseWindow.TabIndex = 5;
            this.btnCloseWindow.Text = "Cancel";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(112, 137);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(90, 23);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnNewShipper
            // 
            this.btnNewShipper.Location = new System.Drawing.Point(12, 137);
            this.btnNewShipper.Name = "btnNewShipper";
            this.btnNewShipper.Size = new System.Drawing.Size(94, 23);
            this.btnNewShipper.TabIndex = 0;
            this.btnNewShipper.Text = "Add Shipper";
            this.btnNewShipper.UseVisualStyleBackColor = true;
            this.btnNewShipper.Click += new System.EventHandler(this.btnNewShipper_Click);
            // 
            // FrmManageShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 169);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnNewShipper);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.cboShipperName);
            this.Controls.Add(this.lblShipperName);
            this.Controls.Add(this.lblShipperID);
            this.Controls.Add(this.cboShipperID);
            this.Controls.Add(this.lblManageShippers);
            this.Name = "FrmManageShippers";
            this.Text = "FrmManageShippers";
            this.Load += new System.EventHandler(this.FrmManageShippers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cboShipperName;
        private System.Windows.Forms.Label lblShipperName;
        private System.Windows.Forms.Label lblShipperID;
        private System.Windows.Forms.ComboBox cboShipperID;
        private System.Windows.Forms.Label lblManageShippers;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnNewShipper;
    }
}