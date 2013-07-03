namespace SalesSystem
{
    partial class FrmCatalogue
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.lblHeadder = new System.Windows.Forms.Label();
            this.dgvCatalogue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 428);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add To Bill";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Location = new System.Drawing.Point(94, 428);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(75, 23);
            this.btnCancelItem.TabIndex = 3;
            this.btnCancelItem.Text = "Cancel";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // lblHeadder
            // 
            this.lblHeadder.AutoSize = true;
            this.lblHeadder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadder.Location = new System.Drawing.Point(12, 9);
            this.lblHeadder.Name = "lblHeadder";
            this.lblHeadder.Size = new System.Drawing.Size(91, 20);
            this.lblHeadder.TabIndex = 4;
            this.lblHeadder.Text = "Catalogue";
            // 
            // dgvCatalogue
            // 
            this.dgvCatalogue.AllowUserToAddRows = false;
            this.dgvCatalogue.AllowUserToDeleteRows = false;
            this.dgvCatalogue.AllowUserToResizeRows = false;
            this.dgvCatalogue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogue.Location = new System.Drawing.Point(12, 32);
            this.dgvCatalogue.Name = "dgvCatalogue";
            this.dgvCatalogue.ReadOnly = true;
            this.dgvCatalogue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogue.Size = new System.Drawing.Size(352, 390);
            this.dgvCatalogue.TabIndex = 5;
            // 
            // FrmCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 460);
            this.Controls.Add(this.dgvCatalogue);
            this.Controls.Add(this.lblHeadder);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnAddItem);
            this.Name = "FrmCatalogue";
            this.Text = "Catalogue";
            this.Load += new System.EventHandler(this.FrmCatalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Label lblHeadder;
        private System.Windows.Forms.DataGridView dgvCatalogue;

    }
}