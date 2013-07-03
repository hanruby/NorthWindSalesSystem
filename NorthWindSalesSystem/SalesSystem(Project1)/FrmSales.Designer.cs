namespace SalesSystem
{
    partial class FrmSales
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
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblComplanyName = new System.Windows.Forms.Label();
            this.lblHeadder = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityperunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsinstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtendedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubOut = new System.Windows.Forms.Label();
            this.lblGSTOut = new System.Windows.Forms.Label();
            this.lblPSTOut = new System.Windows.Forms.Label();
            this.lblTotalOut = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(575, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(58, 13);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date/Time";
            // 
            // lblComplanyName
            // 
            this.lblComplanyName.AutoSize = true;
            this.lblComplanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplanyName.Location = new System.Drawing.Point(10, 9);
            this.lblComplanyName.Name = "lblComplanyName";
            this.lblComplanyName.Size = new System.Drawing.Size(170, 20);
            this.lblComplanyName.TabIndex = 1;
            this.lblComplanyName.Text = "Team Awesome Inc.";
            // 
            // lblHeadder
            // 
            this.lblHeadder.AutoSize = true;
            this.lblHeadder.Location = new System.Drawing.Point(11, 29);
            this.lblHeadder.Name = "lblHeadder";
            this.lblHeadder.Size = new System.Drawing.Size(188, 13);
            this.lblHeadder.TabIndex = 2;
            this.lblHeadder.Text = "Supplying you with awesome since \'12";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(14, 107);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(82, 21);
            this.cmbCustomerID.TabIndex = 3;
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerID_SelectedIndexChanged);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(102, 107);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(176, 21);
            this.cmbCustomerName.TabIndex = 4;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(11, 91);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 5;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(99, 91);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(14, 69);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(166, 21);
            this.cmbEmployees.TabIndex = 7;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(11, 53);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(56, 13);
            this.lblEmployeeName.TabIndex = 8;
            this.lblEmployeeName.Text = "Employee:";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(513, 361);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(93, 23);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "Complete Sale";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(607, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 364);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 12;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AllowUserToResizeColumns = false;
            this.dgvOrderDetails.AllowUserToResizeRows = false;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.productname,
            this.supplierid,
            this.categoryid,
            this.quantityperunit,
            this.unitprice,
            this.unitsinstock,
            this.Quantity,
            this.clmExtendedPrice});
            this.dgvOrderDetails.Location = new System.Drawing.Point(14, 134);
            this.dgvOrderDetails.MultiSelect = false;
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(668, 170);
            this.dgvOrderDetails.TabIndex = 13;
            this.dgvOrderDetails.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvOrderDetails_CellBeginEdit);
            this.dgvOrderDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellEndEdit);
            // 
            // productid
            // 
            this.productid.HeaderText = "Product ID";
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            this.productid.Width = 50;
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 125;
            // 
            // supplierid
            // 
            this.supplierid.HeaderText = "Supplier ID";
            this.supplierid.Name = "supplierid";
            this.supplierid.ReadOnly = true;
            this.supplierid.Width = 53;
            // 
            // categoryid
            // 
            this.categoryid.HeaderText = "Category ID";
            this.categoryid.Name = "categoryid";
            this.categoryid.ReadOnly = true;
            this.categoryid.Width = 60;
            // 
            // quantityperunit
            // 
            this.quantityperunit.HeaderText = "Quantity Per Unit";
            this.quantityperunit.Name = "quantityperunit";
            this.quantityperunit.Width = 55;
            // 
            // unitprice
            // 
            this.unitprice.HeaderText = "Unit Price";
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            this.unitprice.Width = 60;
            // 
            // unitsinstock
            // 
            this.unitsinstock.HeaderText = "Units In Stock";
            this.unitsinstock.Name = "unitsinstock";
            this.unitsinstock.ReadOnly = true;
            this.unitsinstock.Width = 68;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 72;
            // 
            // clmExtendedPrice
            // 
            this.clmExtendedPrice.HeaderText = "Extended Price";
            this.clmExtendedPrice.Name = "clmExtendedPrice";
            this.clmExtendedPrice.ReadOnly = true;
            this.clmExtendedPrice.Width = 60;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(337, 307);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(59, 13);
            this.lblSubTotal.TabIndex = 14;
            this.lblSubTotal.Text = "Sub-Total: ";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(361, 320);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(35, 13);
            this.lblGST.TabIndex = 15;
            this.lblGST.Text = "GST: ";
            // 
            // lblPST
            // 
            this.lblPST.AutoSize = true;
            this.lblPST.Location = new System.Drawing.Point(362, 333);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(34, 13);
            this.lblPST.TabIndex = 16;
            this.lblPST.Text = "PST: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(359, 346);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total: ";
            // 
            // lblSubOut
            // 
            this.lblSubOut.AutoSize = true;
            this.lblSubOut.Location = new System.Drawing.Point(399, 307);
            this.lblSubOut.Name = "lblSubOut";
            this.lblSubOut.Size = new System.Drawing.Size(40, 13);
            this.lblSubOut.TabIndex = 18;
            this.lblSubOut.Text = "$00.00";
            // 
            // lblGSTOut
            // 
            this.lblGSTOut.AutoSize = true;
            this.lblGSTOut.Location = new System.Drawing.Point(399, 320);
            this.lblGSTOut.Name = "lblGSTOut";
            this.lblGSTOut.Size = new System.Drawing.Size(34, 13);
            this.lblGSTOut.TabIndex = 19;
            this.lblGSTOut.Text = "$0.00";
            // 
            // lblPSTOut
            // 
            this.lblPSTOut.AutoSize = true;
            this.lblPSTOut.Location = new System.Drawing.Point(399, 333);
            this.lblPSTOut.Name = "lblPSTOut";
            this.lblPSTOut.Size = new System.Drawing.Size(34, 13);
            this.lblPSTOut.TabIndex = 20;
            this.lblPSTOut.Text = "$0.00";
            // 
            // lblTotalOut
            // 
            this.lblTotalOut.AutoSize = true;
            this.lblTotalOut.Location = new System.Drawing.Point(399, 346);
            this.lblTotalOut.Name = "lblTotalOut";
            this.lblTotalOut.Size = new System.Drawing.Size(40, 13);
            this.lblTotalOut.TabIndex = 21;
            this.lblTotalOut.Text = "$00.00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 396);
            this.Controls.Add(this.lblTotalOut);
            this.Controls.Add(this.lblPSTOut);
            this.Controls.Add(this.lblGSTOut);
            this.Controls.Add(this.lblSubOut);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.cmbCustomerName);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.lblHeadder);
            this.Controls.Add(this.lblComplanyName);
            this.Controls.Add(this.lblDateTime);
            this.Name = "FrmSales";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblComplanyName;
        private System.Windows.Forms.Label lblHeadder;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubOut;
        private System.Windows.Forms.Label lblGSTOut;
        private System.Windows.Forms.Label lblPSTOut;
        private System.Windows.Forms.Label lblTotalOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierid;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityperunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsinstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtendedPrice;
        private System.Windows.Forms.Timer timer1;
    }
}

