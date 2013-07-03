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
    public partial class FrmAddCategory : Form
    {
        Business business;      //Object of type Business

        /// <summary>
        /// Constructor method for FrmAddCategory
        /// </summary>
        public FrmAddCategory()
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
        /// Method triggered when the user selects to add the new category. the
        /// method sends a generated insert statement to the database containing 
        /// the data from the fields in the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCategorie_Click(object sender, EventArgs e)
        {
            String categoryName = "";
            String description = "";

            if (txtCategorieName.Text.Length > 0 && txtDescription.Text.Length > 0)
            {
                categoryName = txtCategorieName.Text;
                description = txtDescription.Text;

                if (business.insertData("INSERT INTO Categories (CategoryName, Description) values ('" + categoryName + "', '" + description + "')", "Categories"))
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
            }
        }
    }
}
