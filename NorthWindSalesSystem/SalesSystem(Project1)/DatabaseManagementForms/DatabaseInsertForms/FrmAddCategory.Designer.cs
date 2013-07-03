namespace SalesSystem.DatabaseManagmentForms.DatabaseInsertForms
{
    partial class FrmAddCategory
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategorieName = new System.Windows.Forms.Label();
            this.lblAddCategories = new System.Windows.Forms.Label();
            this.txtCategorieName = new System.Windows.Forms.TextBox();
            this.btnAddCategorie = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(114, 81);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(331, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(21, 84);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 40;
            this.lblDescription.Text = "Description:";
            // 
            // lblCategorieName
            // 
            this.lblCategorieName.AutoSize = true;
            this.lblCategorieName.Location = new System.Drawing.Point(22, 48);
            this.lblCategorieName.Name = "lblCategorieName";
            this.lblCategorieName.Size = new System.Drawing.Size(83, 13);
            this.lblCategorieName.TabIndex = 38;
            this.lblCategorieName.Text = "Category Name:";
            // 
            // lblAddCategories
            // 
            this.lblAddCategories.AutoSize = true;
            this.lblAddCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCategories.Location = new System.Drawing.Point(12, 9);
            this.lblAddCategories.Name = "lblAddCategories";
            this.lblAddCategories.Size = new System.Drawing.Size(118, 20);
            this.lblAddCategories.TabIndex = 35;
            this.lblAddCategories.Text = "Add Category";
            // 
            // txtCategorieName
            // 
            this.txtCategorieName.Location = new System.Drawing.Point(114, 45);
            this.txtCategorieName.Name = "txtCategorieName";
            this.txtCategorieName.Size = new System.Drawing.Size(177, 20);
            this.txtCategorieName.TabIndex = 2;
            // 
            // btnAddCategorie
            // 
            this.btnAddCategorie.Location = new System.Drawing.Point(271, 107);
            this.btnAddCategorie.Name = "btnAddCategorie";
            this.btnAddCategorie.Size = new System.Drawing.Size(81, 23);
            this.btnAddCategorie.TabIndex = 0;
            this.btnAddCategorie.Text = "Add Category";
            this.btnAddCategorie.UseVisualStyleBackColor = true;
            this.btnAddCategorie.Click += new System.EventHandler(this.btnAddCategorie_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(370, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 141);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCategorie);
            this.Controls.Add(this.txtCategorieName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategorieName);
            this.Controls.Add(this.lblAddCategories);
            this.Name = "FrmAddCategory";
            this.Text = "FrmAddCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategorieName;
        private System.Windows.Forms.Label lblAddCategories;
        private System.Windows.Forms.TextBox txtCategorieName;
        private System.Windows.Forms.Button btnAddCategorie;
        private System.Windows.Forms.Button btnCancel;
    }
}