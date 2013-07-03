namespace SalesSystem.DatabaseManagmentForms
{
    partial class FrmManageProducts
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
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.cboProductID = new System.Windows.Forms.ComboBox();
            this.lblManageProducts = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.txtReOrderLevel = new System.Windows.Forms.TextBox();
            this.txtUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblReOrderLevel = new System.Windows.Forms.Label();
            this.lblUnitsOnOrder = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboProductName
            // 
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(325, 29);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(203, 21);
            this.cboProductName.TabIndex = 2;
            this.cboProductName.SelectedIndexChanged += new System.EventHandler(this.cboProductName_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(229, 34);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 35;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(15, 37);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 34;
            this.lblProductID.Text = "Product ID:";
            // 
            // cboProductID
            // 
            this.cboProductID.FormattingEnabled = true;
            this.cboProductID.Location = new System.Drawing.Point(109, 34);
            this.cboProductID.Name = "cboProductID";
            this.cboProductID.Size = new System.Drawing.Size(112, 21);
            this.cboProductID.TabIndex = 1;
            this.cboProductID.SelectedIndexChanged += new System.EventHandler(this.cboProductID_SelectedIndexChanged);
            // 
            // lblManageProducts
            // 
            this.lblManageProducts.AutoSize = true;
            this.lblManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProducts.Location = new System.Drawing.Point(12, 9);
            this.lblManageProducts.Name = "lblManageProducts";
            this.lblManageProducts.Size = new System.Drawing.Size(149, 20);
            this.lblManageProducts.TabIndex = 32;
            this.lblManageProducts.Text = "Manage Products";
            // 
            // cboSupplier
            // 
            this.cboSupplier.Enabled = false;
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(325, 56);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(203, 21);
            this.cboSupplier.TabIndex = 4;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(229, 64);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 13);
            this.lblSupplier.TabIndex = 39;
            this.lblSupplier.Text = "Supplier:";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(15, 64);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(55, 13);
            this.lblCategorie.TabIndex = 38;
            this.lblCategorie.Text = "Categorie:";
            // 
            // cboCategorie
            // 
            this.cboCategorie.Enabled = false;
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(109, 61);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(112, 21);
            this.cboCategorie.TabIndex = 3;
            // 
            // txtReOrderLevel
            // 
            this.txtReOrderLevel.Location = new System.Drawing.Point(465, 110);
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.Size = new System.Drawing.Size(63, 20);
            this.txtReOrderLevel.TabIndex = 9;
            // 
            // txtUnitsOnOrder
            // 
            this.txtUnitsOnOrder.Location = new System.Drawing.Point(325, 110);
            this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            this.txtUnitsOnOrder.Size = new System.Drawing.Size(50, 20);
            this.txtUnitsOnOrder.TabIndex = 8;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(109, 110);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(112, 20);
            this.txtUnitsInStock.TabIndex = 7;
            // 
            // lblReOrderLevel
            // 
            this.lblReOrderLevel.AutoSize = true;
            this.lblReOrderLevel.Location = new System.Drawing.Point(381, 113);
            this.lblReOrderLevel.Name = "lblReOrderLevel";
            this.lblReOrderLevel.Size = new System.Drawing.Size(82, 13);
            this.lblReOrderLevel.TabIndex = 48;
            this.lblReOrderLevel.Text = "Re-Order Level:";
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.AutoSize = true;
            this.lblUnitsOnOrder.Location = new System.Drawing.Point(229, 117);
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Size = new System.Drawing.Size(80, 13);
            this.lblUnitsOnOrder.TabIndex = 47;
            this.lblUnitsOnOrder.Text = "Units On Order:";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(14, 117);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(77, 13);
            this.lblUnitsInStock.TabIndex = 46;
            this.lblUnitsInStock.Text = "Units In Stock:";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(325, 84);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(203, 20);
            this.txtQuantityPerUnit.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(109, 85);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(112, 20);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(229, 88);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(90, 13);
            this.lblQuantityPerUnit.TabIndex = 53;
            this.lblQuantityPerUnit.Text = "Quantity Per Unit:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(14, 91);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 52;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(440, 149);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(88, 17);
            this.chkDiscontinued.TabIndex = 10;
            this.chkDiscontinued.Text = "Discontinued";
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(430, 172);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(97, 23);
            this.btnCloseWindow.TabIndex = 12;
            this.btnCloseWindow.Text = "Cancel";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(224, 172);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(101, 23);
            this.btnSaveChanges.TabIndex = 11;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(18, 172);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(101, 23);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "Add Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // FrmManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 204);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnSaveChanges);
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
            this.Controls.Add(this.lblManageProducts);
            this.Name = "FrmManageProducts";
            this.Text = "FrmManageProducts";
            this.Load += new System.EventHandler(this.FrmManageProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ComboBox cboProductID;
        private System.Windows.Forms.Label lblManageProducts;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.TextBox txtReOrderLevel;
        private System.Windows.Forms.TextBox txtUnitsOnOrder;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label lblReOrderLevel;
        private System.Windows.Forms.Label lblUnitsOnOrder;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.CheckBox chkDiscontinued;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnNewProduct;
    }
}