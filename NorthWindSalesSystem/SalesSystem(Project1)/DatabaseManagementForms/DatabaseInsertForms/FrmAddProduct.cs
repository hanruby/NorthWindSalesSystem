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
/// <authors> Kyle Pallo, Gerald Humphries, Charaf </authors>
/// <date> 07, December, 2012 </date>
namespace SalesSystem.DatabaseManagmentForms.DatabaseInsertForms
{
    public partial class FrmAddProduct : Form
    {
        Business business;

        /// <summary>
        /// Constructor method for FrmAddProduct
        /// </summary>
        public FrmAddProduct()
        {
            this.business = Business.getBusiness();
            InitializeComponent();

            DataTable suppliers = business.getTable("Products");
            DataTable categories = business.getTable("Products");
            for (int i = 0; i < suppliers.Rows.Count; i++)
            {
                cboSupplier.Items.Add(suppliers.Rows[i][0]);
            }
            for (int i = 0; i < categories.Rows.Count; i++)
            {
                cboCategorie.Items.Add(categories.Rows[i][0]);
            }
        }

        /// <summary>
        /// Method triggered when the user clicks the cancel button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method triggered when the user selects to add the new product. the
        /// method sends a generated insert statement to the database containing 
        /// the data from the fields in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            String productName = "";
            int categoryID = 0;
            int supplierID = 0;
            decimal unitPrice = 0;
            String quantityPerUnit = "";
            int unitsInStock = 0;
            int unitsOnOrder = 0;
            int reorderLevel = 0;
            bool discontinued = false;
            

            if (cboProductName.Text.Length > 0 && cboCategorie.Text.Length > 0 && cboSupplier.Text.Length > 0 && txtUnitPrice.Text.Length > 0 && txtQuantityPerUnit.Text.Length > 0 && txtUnitsInStock.Text.Length > 0 && txtUnitsOnOrder.Text.Length > 0 && txtReOrderLevel.Text.Length > 0)
            {
                if (decimal.TryParse(txtUnitPrice.Text.ToString(), out unitPrice) && int.TryParse(txtUnitsInStock.Text.ToString(), out unitsInStock) && int.TryParse(txtUnitsOnOrder.Text.ToString(), out unitsOnOrder) && int.TryParse(txtReOrderLevel.Text.ToString(), out reorderLevel)){
                    productName = cboProductName.Text;
                    quantityPerUnit = txtQuantityPerUnit.Text;
                    discontinued = chkDiscontinued.Checked;
                    String insertionString = "INSERT INTO Products (productName, category, supplier, unitPrice, quantityPerUnit, UnitsOnStock, UnitsOnOrder, reOrderLevel, Discontinued) values ('"
                        + productName + "', " + categoryID + ", " + supplierID 
                        + ", " + unitPrice + ", '" + quantityPerUnit + "', " 
                        + unitsInStock + ", " + unitsOnOrder + ", " 
                        + reorderLevel + ", " + discontinued + ")";
                    if (business.insertData(insertionString, "Products"))
                    {
                        MessageBox.Show("Success");
                        this.Close();
                    }
                }
            }

            //private void cboProductID_TextChanged(object sender, EventArgs e)
            //{

            //}
        }
    }
}
