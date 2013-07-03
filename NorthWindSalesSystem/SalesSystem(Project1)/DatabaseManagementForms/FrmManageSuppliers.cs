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
    public partial class FrmManageSuppliers : Form
    {
        private Business business;      //Object of type Business
        private DataTable suppliers;    

        /// <summary>
        /// Constructor method for the class FrmManageSuppliers
        /// </summary>
        public FrmManageSuppliers()
        {
            InitializeComponent();
            business = Business.getBusiness();
        }

        /// <summary>
        /// Method to populate the pields on the form from the datatable
        /// </summary>
        private void PopulateFields()
        {
            txtTitle.Text = suppliers.Rows[cmbSupplierID.SelectedIndex][3].ToString();
            txtContactName.Text = suppliers.Rows[cmbSupplierID.SelectedIndex][2].ToString();
            txtCity.Text = suppliers.Rows[cmbSupplierID.SelectedIndex][5].ToString();
            txtAddress.Text = suppliers.Rows[cmbSupplierID.SelectedIndex][4].ToString();
            txtPostalCode.Text = suppliers.Rows[cmbSupplierID.SelectedIndex][7].ToString();
            txtRegion.Text = suppliers.Rows[cmbSupplierID.SelectedIndex][6].ToString();
            txtCountry.Text = suppliers.Rows[cmbSupplierID.SelectedIndex][8].ToString();
            txtPhone.Text = suppliers.Rows[cmbSupplierID.SelectedIndex][9].ToString();
            txtFax.Text = suppliers.Rows[cmbSupplierID.SelectedIndex][10].ToString();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCompanyName.SelectedIndex = cmbSupplierID.SelectedIndex;
            PopulateFields();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSupplierID.SelectedIndex = cmbCompanyName.SelectedIndex;
            PopulateFields();
        }

        /// <summary>
        /// Method to bring up the form to new a Shipper.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewShipper_Click(object sender, EventArgs e)
        {
            FrmAddSupplier addSupplier = new FrmAddSupplier();
            addSupplier.Text = "Add Supplier";
            addSupplier.Show();
        }

        /// <summary>
        /// Method ran every time the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManageSuppliers_Load(object sender, EventArgs e)
        {
            suppliers = business.getTable("Suppliers");
            for (int i = 0; i < suppliers.Rows.Count; i++)
            {
                cmbSupplierID.Items.Add(suppliers.Rows[i][0].ToString());
                cmbCompanyName.Items.Add(suppliers.Rows[i][1].ToString());
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
            int supplierID = 0;            
            String companyName = "";
            String contactName = "";
            String contactTitle = "";
	        String address = "";
            String city = "";
	         String region = "";
            String postalCode = "";
            String country = "";
            String phone = "";
            String fax = "";

            if (cmbCompanyName.Text.Length > 0)
            {
                supplierID = int.Parse(cmbSupplierID.Text);
                companyName = cmbCompanyName.Text.Replace("'", "''");
                contactName = txtContactName.Text;
                contactTitle = txtTitle.Text;
	            address = txtAddress.Text;
                city = txtCity.Text;
	            region = txtRegion.Text;
                postalCode = txtPostalCode.Text;
                country = txtCountry.Text;
                phone = txtPhone.Text;
                fax = txtFax.Text;

                if (business.insertData("UPDATE Suppliers SET CompanyName='" + companyName + "', ContactName='" + contactName + "', ContactTitle='" + contactTitle + "', Address='" + address + "', City='" + city + "', Region='" + region + "', PostalCode='" + postalCode + "', Country='" + country + "', Phone='" + phone + "', Fax='" + fax
                  + "' WHERE SupplierID=" + supplierID, "Suppliers"))
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
    
