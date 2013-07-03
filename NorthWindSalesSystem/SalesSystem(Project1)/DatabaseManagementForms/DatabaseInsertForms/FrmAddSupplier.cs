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
    public partial class FrmAddSupplier : Form
    {
        Business business;

        /// <summary>
        /// Constructor method for FrmAddCategory
        /// </summary>
        public FrmAddSupplier()
        {
            this.business = Business.getBusiness();
            InitializeComponent();
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
        /// Method triggered when the user selects to add the new supplier. the
        /// method sends a generated insert statement to the database containing 
        /// the data from the fields in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
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


            if (txtCompanyName.Text.Length > 0 )
            {
                companyName = txtCompanyName.Text.Replace("'", "''");
                contactName = txtContactName.Text;
                contactTitle = txtTitle.Text;
	            address = txtAddress.Text;
                city = txtCity.Text;
	            region = txtRegion.Text;
                postalCode = txtPostalCode.Text;
                country = txtCountry.Text;
                phone = txtPhone.Text;
                fax = txtFax.Text;

                if (business.insertData("INSERT INTO Suppliers (companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax) values ('" + companyName + "', '" + contactName + "', '" + contactTitle + "' , '" + address + "' , '" + city + "', '" + region + "', '" + postalCode + "', '" + country + "', '" + phone + "' , '" + fax + "' )", "Suppliers")) ;
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
            }
        }
    }
}
