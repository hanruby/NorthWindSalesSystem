using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// Group Project 2
/// This project is a point of sale programme for the the 
/// NorthWind database.
/// </summary>
/// <authors> Kyle Pallo, Gerald Humphries, Charaf-Eddine Khiari </authors>
/// <date> 07, December, 2012 </date>
namespace SalesSystem
{
    public partial class FrmCatalogue : Form
    {
        /// <summary>
        /// Constructor method for class FrmCatalogue. Stores the reference to the FrmSales object that 
        /// instantiated this. Uses that reference to send back data.
        /// </summary>
        /// <param name="frm">The sales form that called this method.</param>
        public FrmCatalogue(FrmSales frm)
        {
            InitializeComponent();
            business = Business.getBusiness();
            frmSales = frm;
        }

        /// <summary>
        /// Onclick event for btnAddItem. Sends a DataGridViewRow array to the stored FrmSales reference
        /// based on the user's selection.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow[] selectedProducts = new DataGridViewRow[dgvCatalogue.SelectedRows.Count];

            for (int i = 0; i < dgvCatalogue.SelectedRows.Count; i++)
                {
                    DataGridViewRow rowToAdd = (DataGridViewRow)dgvCatalogue.SelectedRows[i].Clone();
                    rowToAdd.CreateCells(dgvCatalogue);
                    for (int j = 0; j < dgvCatalogue.SelectedRows[i].Cells.Count; j++)
                    {
                        rowToAdd.Cells[j].Value = dgvCatalogue.SelectedRows[i].Cells[j].Value;
                    }
                selectedProducts[i] = rowToAdd;
                }
            frmSales.addProduct(selectedProducts);
            this.Close();
        }

        /// <summary>
        /// Onclick event for btnCancel. Closes the form.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load event for FrmCatalogue. Adds product data from the database to dgvCatalogue, then hides
        /// the columns that should not be displayed.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void FrmCatalogue_Load(object sender, EventArgs e)
        {
            DataTable dt = this.business.getTable("Products");

            dgvCatalogue.DataSource = dt;
            dgvCatalogue.Columns[0].Visible = false;
            dgvCatalogue.Columns[3].Visible = false;
            dgvCatalogue.Columns[6].Visible = false;
            dgvCatalogue.Columns[7].Visible = false;
            dgvCatalogue.Columns[8].Visible = false;
            dgvCatalogue.Columns[9].Visible = false;

        }

        private FrmSales frmSales;
        private Business business;
    }
}

