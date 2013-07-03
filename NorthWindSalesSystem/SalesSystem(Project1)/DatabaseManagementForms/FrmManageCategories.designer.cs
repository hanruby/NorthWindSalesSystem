namespace SalesSystem.DatabaseManagmentForms
{
    partial class FrmManageCategories
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
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.cmbCategoryID = new System.Windows.Forms.ComboBox();
            this.lblManageCategories = new System.Windows.Forms.Label();
            this.lblPicture = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(342, 229);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(97, 23);
            this.btnCloseWindow.TabIndex = 5;
            this.btnCloseWindow.Text = "Close Window";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(173, 229);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(101, 23);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(12, 229);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(107, 23);
            this.btnNewCategory.TabIndex = 0;
            this.btnNewCategory.Text = "New Category";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategorie_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(82, 95);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(357, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 32;
            this.lblDescription.Text = "Description:";
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(261, 54);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(178, 21);
            this.cmbCategoryName.TabIndex = 2;
            this.cmbCategoryName.SelectedIndexChanged += new System.EventHandler(this.cmbCategorieName_SelectedIndexChanged);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(169, 57);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(83, 13);
            this.lblCategoryName.TabIndex = 30;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(13, 57);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(66, 13);
            this.lblCategoryID.TabIndex = 29;
            this.lblCategoryID.Text = "Category ID:";
            // 
            // cmbCategoryID
            // 
            this.cmbCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryID.FormattingEnabled = true;
            this.cmbCategoryID.Location = new System.Drawing.Point(87, 53);
            this.cmbCategoryID.Name = "cmbCategoryID";
            this.cmbCategoryID.Size = new System.Drawing.Size(77, 21);
            this.cmbCategoryID.TabIndex = 1;
            this.cmbCategoryID.SelectedIndexChanged += new System.EventHandler(this.cmbCategorieID_SelectedIndexChanged);
            // 
            // lblManageCategories
            // 
            this.lblManageCategories.AutoSize = true;
            this.lblManageCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCategories.Location = new System.Drawing.Point(12, 9);
            this.lblManageCategories.Name = "lblManageCategories";
            this.lblManageCategories.Size = new System.Drawing.Size(165, 20);
            this.lblManageCategories.TabIndex = 27;
            this.lblManageCategories.Text = "Manage Categories";
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(13, 135);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(43, 13);
            this.lblPicture.TabIndex = 53;
            this.lblPicture.Text = "Picture:";
            // 
            // FrmManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 264);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbCategoryName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.cmbCategoryID);
            this.Controls.Add(this.lblManageCategories);
            this.Name = "FrmManageCategories";
            this.Text = "FrmManageCategories";
            this.Load += new System.EventHandler(this.FrmManageCategories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.ComboBox cmbCategoryID;
        private System.Windows.Forms.Label lblManageCategories;
        private System.Windows.Forms.Label lblPicture;
    }
}