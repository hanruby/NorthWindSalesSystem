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
    public partial class FrmAddEmployee : Form
    {
        Business business;

        /// <summary>
        /// Constructor method for FrmAddEmployee
        /// </summary>
        public FrmAddEmployee()
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
        /// Method triggered when the user selects to add the new employee. the
        /// method sends a generated insert statement to the database containing 
        /// the data from the fields in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            String empLName = "";
            String empFName = "";
            String title= "";
            String courtesy= "";
            String address= "";
            String postalCode= "";
            String city= "";
            String region= "";
            String country = "";
            String phone= "";
            String extension = "";
            String notes= "";

            if (txtFName.Text.Length > 0)
            {
                empLName = txtLName.Text;
                empFName = txtFName.Text;
                title = txtTitle.Text;
                courtesy = txtCourtesy.Text;
                address = txtAddress.Text;
                postalCode = txtPostalCode.Text;
                city = txtCity.Text;
                region = txtRegion.Text;
                country = txtCountry.Text;
                phone = txtPhone.Text;
                extension = txtExtension.Text;
                notes = txtNotes.Text;
                if (business.insertData("INSERT INTO Employees values ('" + empFName + " " + empLName + "', '" + title + "', '" + courtesy + "', '" + address + "', '" + city + "', '" + region + "', '" + postalCode + "', '" + country + "', '" + phone + "', '" + extension + "', '" + notes + "')", "Employees"))
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
            }
        }
    }
}
