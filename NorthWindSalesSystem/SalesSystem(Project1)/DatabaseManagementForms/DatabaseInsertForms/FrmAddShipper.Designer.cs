namespace SalesSystem.DatabaseManagmentForms.DatabaseInsertForms
{
    partial class FrmAddShipper
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
            this.btnNewShipper = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblShipperName = new System.Windows.Forms.Label();
            this.lblAddShippers = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(206, 137);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(97, 23);
            this.btnCloseWindow.TabIndex = 65;
            this.btnCloseWindow.Text = "Cancel";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            // 
            // btnNewShipper
            // 
            this.btnNewShipper.Location = new System.Drawing.Point(10, 137);
            this.btnNewShipper.Name = "btnNewShipper";
            this.btnNewShipper.Size = new System.Drawing.Size(94, 23);
            this.btnNewShipper.TabIndex = 60;
            this.btnNewShipper.Text = "Add Shipper";
            this.btnNewShipper.UseVisualStyleBackColor = true;
            this.btnNewShipper.Click += new System.EventHandler(this.btnNewShipper_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(100, 109);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(118, 20);
            this.txtPhone.TabIndex = 63;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(11, 112);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 69;
            this.lblPhone.Text = "Phone:";
            // 
            // lblShipperName
            // 
            this.lblShipperName.AutoSize = true;
            this.lblShipperName.Location = new System.Drawing.Point(11, 79);
            this.lblShipperName.Name = "lblShipperName";
            this.lblShipperName.Size = new System.Drawing.Size(77, 13);
            this.lblShipperName.TabIndex = 68;
            this.lblShipperName.Text = "Shipper Name:";
            // 
            // lblAddShippers
            // 
            this.lblAddShippers.AutoSize = true;
            this.lblAddShippers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddShippers.Location = new System.Drawing.Point(6, 9);
            this.lblAddShippers.Name = "lblAddShippers";
            this.lblAddShippers.Size = new System.Drawing.Size(117, 20);
            this.lblAddShippers.TabIndex = 66;
            this.lblAddShippers.Text = "Add Shippers";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(100, 76);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(203, 20);
            this.txtCompanyName.TabIndex = 70;
            // 
            // FrmAddShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 169);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnNewShipper);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblShipperName);
            this.Controls.Add(this.lblAddShippers);
            this.Name = "FrmAddShipper";
            this.Text = "FrmAddShipper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnNewShipper;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblShipperName;
        private System.Windows.Forms.Label lblAddShippers;
        private System.Windows.Forms.TextBox txtCompanyName;

    }
}