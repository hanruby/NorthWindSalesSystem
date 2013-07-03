using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SalesSystem.DatabaseManagmentForms.DatabaseInsertForms;

/// <summary>
/// Group Project 2
/// This project is a point of sale programme for the the 
/// NorthWind database.
/// </summary>
/// <authors> Kyle Pallo, Gerald Humphries, Charaf </authors>
/// <date> 07, December, 2012 </date>
namespace SalesSystem.DatabaseManagmentForms
{
    public partial class FrmManageProducts : Form
    {
        private Business business;      //Object of type Business

        /// <summary>
        /// Constructor method for the class FrmManageProducts
        /// </summary>
        public FrmManageProducts()
        {
            InitializeComponent();
            business = Business.getBusiness();
        }

        /// <summary>
        /// Method to populate the pields on the form from the datatable
        /// </summary>
        private void PopulateFields()
        {
            cboCategorie.Enabled = true;
            cboSupplier.Enabled = true;
            DataTable products = business.getTable("Products");
            cboCategorie.Text = products.Rows[cboProductID.SelectedIndex][2].ToString();
            cboSupplier.Text = products.Rows[cboProductID.SelectedIndex][3].ToString();
            txtQuantityPerUnit.Text = products.Rows[cboProductID.SelectedIndex][4].ToString();
            txtUnitPrice.Text = products.Rows[cboProductID.SelectedIndex][5].ToString();
            txtUnitsInStock.Text = products.Rows[cboProductID.SelectedIndex][6].ToString();
            txtUnitsOnOrder.Text = products.Rows[cboProductID.SelectedIndex][7].ToString();
            txtReOrderLevel.Text = products.Rows[cboProductID.SelectedIndex][8].ToString();
            chkDiscontinued.Checked = (bool)products.Rows[cboProductID.SelectedIndex][9];
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProductName.SelectedIndex = cboProductID.SelectedIndex;
            PopulateFields();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProductID.SelectedIndex = cboProductName.SelectedIndex;
            PopulateFields();
        }

        /// <summary>
        /// Method to bring up the form to add a product.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewProducts_Click(object sender, EventArgs e)
        {
            FrmAddProduct addProduct = new FrmAddProduct();
            addProduct.Text = "Add Products";
            addProduct.Show();
        }

        /// <summary>
        /// Method ran every time the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManageProducts_Load(object sender, EventArgs e)
        {
            DataTable products = business.getTable("Products");
            DataTable suppliers = business.getTable("Suppliers");
            DataTable categories = business.getTable("Categories");
            for (int i = 0; i < products.Rows.Count; i++)
            {
                cboProductID.Items.Add(products.Rows[i][0]);
                cboProductName.Items.Add(products.Rows[i][1]);
            }
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
        /// Method ran when the close window button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method ran when the user selects to save changes. it sends an update
        /// querry to the database containing the info from the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
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
            int productID = int.Parse(cboProductID.Text);


            if (cboProductName.Text.Length > 0 && txtUnitPrice.Text.Length > 0 && txtQuantityPerUnit.Text.Length > 0 && txtUnitsInStock.Text.Length > 0 && txtUnitsOnOrder.Text.Length > 0 && txtReOrderLevel.Text.Length > 0)
            {
                if (decimal.TryParse(txtUnitPrice.Text.ToString(), out unitPrice) && int.TryParse(txtUnitsInStock.Text.ToString(), out unitsInStock) && int.TryParse(txtUnitsOnOrder.Text.ToString(), out unitsOnOrder) && int.TryParse(txtReOrderLevel.Text.ToString(), out reorderLevel))
                {
                    productName = cboProductName.Text.Replace("'", "''");
                    quantityPerUnit = txtQuantityPerUnit.Text;
                    discontinued = chkDiscontinued.Checked;
                    String updateString = "UPDATE Products SET ProductName='" + productName + "', CategoryID=" + categoryID
                        + ", SupplierID=" + supplierID + ", UnitPrice=" + unitPrice + ", QuantityPerUnit='" + quantityPerUnit
                        + "', UnitsInStock=" + unitsInStock + ", UnitsOnOrder=" + unitsOnOrder + ", ReOrderLevel=" + reorderLevel
                        + ", Discontinued=" + discontinued + " WHERE ProductID=" + productID;
                    if (business.insertData(updateString, "Products"))
                    {
                        MessageBox.Show("Success");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Row failed to update!");
                    }
                }
            }
        }
    }
}