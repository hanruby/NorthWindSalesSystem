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
    public partial class FrmAddCustomer : Form
    {
        Business business;

        /// <summary>
        /// Constructor method for FrmAddCustomer
        /// </summary>
        public FrmAddCustomer()
        {
            InitializeComponent();
            business = Business.getBusiness();
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
        /// Method triggered when the user selects to add the new customer. the
        /// method sends a generated insert statement to the database containing 
        /// the data from the fields in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            String custID = "";
            String compName= "";
            String contTitle= "";
            String contName= "";
            String address= "";
            String postalCode= "";
            String city= "";
            String region= "";
            String country = "";
            String phone= "";
            String fax= "";

            if (txtCustomerID.Text.Length > 0 && txtCompanyName.Text.Length > 0)
            {
                custID = txtCustomerID.Text;
                compName = txtCompanyName.Text;
                contTitle = txtContactTitle.Text;
                contName = txtContactName.Text;
                address = txtAddress.Text;
                postalCode = txtPostalCode.Text;
                city = txtCity.Text;
                region = txtRegion.Text;
                country = txtCountry.Text;
                phone = txtPhone.Text;
                fax = txtFax.Text;
                if (business.insertData("INSERT INTO Customers values ('" + custID + "', '" + compName + "', '" + contName + "', '" + contTitle + "', '" + address + "', '" + city + "', '" + region + "', '" + postalCode + "', '" + country + "', '" + phone + "', '" + fax + "')", "Customers"))
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
            }
        }
    }
}
