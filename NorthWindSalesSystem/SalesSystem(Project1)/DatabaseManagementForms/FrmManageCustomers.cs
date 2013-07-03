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
    public partial class FrmManageCustomers : Form
    {
        private Business business;      //Object of type Business
        private DataTable customers;    //Object of type datatable to contain the category data

        /// <summary>
        /// Constructor Method for the class FrmManageCustomers
        /// </summary>
        public FrmManageCustomers()
        {
            InitializeComponent();
            business = Business.getBusiness();
        }

        /// <summary>
        /// Method to populate the pields on the form from the datatable
        /// </summary>
        private void PopulateFields(int index)
        {

            txtContactTitle.Text = customers.Rows[cmbCustomerID.SelectedIndex][3].ToString();
            txtContactName.Text = customers.Rows[cmbCustomerID.SelectedIndex][2].ToString();
            txtCity.Text = customers.Rows[cmbCustomerID.SelectedIndex][5].ToString();
            txtAddress.Text = customers.Rows[cmbCustomerID.SelectedIndex][4].ToString();
            txtRegion.Text = customers.Rows[cmbCustomerID.SelectedIndex][6].ToString();
            txtPostalCode.Text = customers.Rows[cmbCustomerID.SelectedIndex][7].ToString();
            txtCountry.Text = customers.Rows[cmbCustomerID.SelectedIndex][8].ToString();
            txtPhone.Text = customers.Rows[cmbCustomerID.SelectedIndex][9].ToString();
            txtFax.Text = customers.Rows[cmbCustomerID.SelectedIndex][10].ToString();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCompanyName.SelectedIndex = cmbCustomerID.SelectedIndex;
            PopulateFields(cmbCustomerID.SelectedIndex);
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomerID.SelectedIndex = cmbCompanyName.SelectedIndex;
            PopulateFields(cmbCustomerID.SelectedIndex);
        }

        /// <summary>
        /// Method to bring up the form to add a customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer addCustomer = new FrmAddCustomer();
            addCustomer.Text = "Add Customers";
            addCustomer.Show();
        }

        /// <summary>
        /// Method ran every time the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManageCustomers_Load(object sender, EventArgs e)
        {
            customers = business.getTable("Customers");
            for (int i = 0; i < customers.Rows.Count; i++)
            {
                cmbCustomerID.Items.Add(customers.Rows[i][0].ToString());
                cmbCompanyName.Items.Add(customers.Rows[i][1].ToString());
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
        /// Method to bring up the form to add a Customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer addCustomer = new FrmAddCustomer();
            addCustomer.Text = "Manage Customers";
            addCustomer.Show();
        }

        /// <summary>
        /// Method ran when the user selects to save changes. it sends an update
        /// querry to the database containing the info from the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            String custID = "";
            String compName = "";
            String contTitle = "";
            String contName = "";
            String address = "";
            String postalCode = "";
            String city = "";
            String region = "";
            String country = "";
            String phone = "";
            String fax = "";
            if (cmbCustomerID.SelectedIndex != -1 && cmbCompanyName.SelectedIndex != -1)
            {
                custID = cmbCustomerID.Text;
                compName = cmbCompanyName.Text;
                contTitle = txtContactTitle.Text;
                contName = txtContactName.Text;
                address = txtAddress.Text;
                postalCode = txtPostalCode.Text;
                city = txtCity.Text;
                country = txtCountry.Text;
                phone = txtPhone.Text;
                fax = txtFax.Text;
                if (txtRegion.Text.Length > 0)
                    region = txtRegion.Text;
                else
                    region = " ";
                if (business.insertData("UPDATE Customers SET CustomerID='" + custID + "', CompanyName='" + compName + "', ContactName='" + contName + "', ContactTitle='" + contTitle + "', Address='" + address + "', City='" + city + "', Region='" + region + "', PostalCode='" + postalCode + "', Country='" + country + "', Phone='" + phone + "', Fax='" + fax + "' WHERE CustomerID='" + cmbCustomerID.Text.ToString() + "'", "Customers"))
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