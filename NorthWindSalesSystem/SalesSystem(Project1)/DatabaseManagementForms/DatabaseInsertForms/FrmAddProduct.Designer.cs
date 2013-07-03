namespace SalesSystem.DatabaseManagmentForms.DatabaseInsertForms
{
    partial class FrmAddProduct
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
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtReOrderLevel = new System.Windows.Forms.TextBox();
            this.txtUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblReOrderLevel = new System.Windows.Forms.Label();
            this.lblUnitsOnOrder = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.cboProductID = new System.Windows.Forms.ComboBox();
            this.lblAddProducts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(431, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(19, 173);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(101, 23);
            this.btnNewProduct.TabIndex = 54;
            this.btnNewProduct.Text = "Add Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(441, 150);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(88, 17);
            this.chkDiscontinued.TabIndex = 64;
            this.chkDiscontinued.Text = "Discontinued";
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(326, 85);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(203, 20);
            this.txtQuantityPerUnit.TabIndex = 60;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(110, 86);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(112, 20);
            this.txtUnitPrice.TabIndex = 59;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(230, 89);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(90, 13);
            this.lblQuantityPerUnit.TabIndex = 76;
            this.lblQuantityPerUnit.Text = "Quantity Per Unit:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(15, 92);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 75;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // txtReOrderLevel
            // 
            this.txtReOrderLevel.Location = new System.Drawing.Point(466, 111);
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.Size = new System.Drawing.Size(63, 20);
            this.txtReOrderLevel.TabIndex = 63;
            // 
            // txtUnitsOnOrder
            // 
            this.txtUnitsOnOrder.Location = new System.Drawing.Point(326, 111);
            this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            this.txtUnitsOnOrder.Size = new System.Drawing.Size(50, 20);
            this.txtUnitsOnOrder.TabIndex = 62;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(110, 111);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(112, 20);
            this.txtUnitsInStock.TabIndex = 61;
            // 
            // lblReOrderLevel
            // 
            this.lblReOrderLevel.AutoSize = true;
            this.lblReOrderLevel.Location = new System.Drawing.Point(382, 114);
            this.lblReOrderLevel.Name = "lblReOrderLevel";
            this.lblReOrderLevel.Size = new System.Drawing.Size(82, 13);
            this.lblReOrderLevel.TabIndex = 74;
            this.lblReOrderLevel.Text = "Re-Order Level:";
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.AutoSize = true;
            this.lblUnitsOnOrder.Location = new System.Drawing.Point(230, 118);
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Size = new System.Drawing.Size(80, 13);
            this.lblUnitsOnOrder.TabIndex = 73;
            this.lblUnitsOnOrder.Text = "Units On Order:";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(15, 118);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(77, 13);
            this.lblUnitsInStock.TabIndex = 72;
            this.lblUnitsInStock.Text = "Units In Stock:";
            // 
            // cboSupplier
            // 
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(326, 57);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(203, 21);
            this.cboSupplier.TabIndex = 58;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(230, 65);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 13);
            this.lblSupplier.TabIndex = 71;
            this.lblSupplier.Text = "Supplier:";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(16, 65);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(55, 13);
            this.lblCategorie.TabIndex = 70;
            this.lblCategorie.Text = "Categorie:";
            // 
            // cboCategorie
            // 
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(110, 62);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(112, 21);
            this.cboCategorie.TabIndex = 57;
            // 
            // cboProductName
            // 
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(326, 30);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(203, 21);
            this.cboProductName.TabIndex = 56;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(230, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 69;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(16, 38);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 68;
            this.lblProductID.Text = "Product ID:";
            // 
            // cboProductID
            // 
            this.cboProductID.FormattingEnabled = true;
            this.cboProductID.Location = new System.Drawing.Point(110, 35);
            this.cboProductID.Name = "cboProductID";
            this.cboProductID.Size = new System.Drawing.Size(112, 21);
            this.cboProductID.TabIndex = 55;
            // 
            // lblAddProducts
            // 
            this.lblAddProducts.AutoSize = true;
            this.lblAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProducts.Location = new System.Drawing.Point(13, 10);
            this.lblAddProducts.Name = "lblAddProducts";
            this.lblAddProducts.Size = new System.Drawing.Size(117, 20);
            this.lblAddProducts.TabIndex = 67;
            this.lblAddProducts.Text = "Add Products";
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 204);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.chkDiscontinued);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblQuantityPerUnit);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.txtReOrderLevel);
            this.Controls.Add(this.txtUnitsOnOrder);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.lblReOrderLevel);
            this.Controls.Add(this.lblUnitsOnOrder);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.cboCategorie);
            this.Controls.Add(this.cboProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.cboProductID);
            this.Controls.Add(this.lblAddProducts);
            this.Name = "FrmAddProduct";
            this.Text = "FrmAddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.CheckBox chkDiscontinued;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtReOrderLevel;
        private System.Windows.Forms.TextBox txtUnitsOnOrder;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label lblReOrderLevel;
        private System.Windows.Forms.Label lblUnitsOnOrder;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ComboBox cboProductID;
        private System.Windows.Forms.Label lblAddProducts;

    }
}