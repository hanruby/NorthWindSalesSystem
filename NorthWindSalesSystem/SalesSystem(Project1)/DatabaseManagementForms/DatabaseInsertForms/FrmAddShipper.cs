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
    public partial class FrmAddShipper : Form
    {
        private Business business;
        /// <summary>
        /// Constructor method for FrmAddShipper
        /// </summary>
        public FrmAddShipper()
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
        /// Method triggered when the user selects to add the new Shipper. the
        /// method sends a generated insert statement to the database containing 
        /// the data from the fields in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewShipper_Click(object sender, EventArgs e)
        {
            String companyName = "";
            String phone = "";
            if (txtPhone.Text.Length > 0)
            {
                companyName = txtCompanyName.Text;
                phone = txtPhone.Text;
                if (business.insertData("INSERT INTO Shippers (CompanyName, Phone) values ('" + companyName + "', '" + phone + "')", "Shippers"))
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
            }
        }
    }
}
