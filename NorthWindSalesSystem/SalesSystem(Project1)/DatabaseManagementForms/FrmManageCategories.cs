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
    public partial class FrmManageCategories : Form
    {
        private Business business;      //Object of type Business
        private DataTable categories;   //Object of type datatable to contain the category data

        /// <summary>
        /// Constructor method for the class FrmManageCategories
        /// </summary>
        public FrmManageCategories()
        {
            InitializeComponent();
            business = Business.getBusiness();
        }

        /// <summary>
        /// Method to populate the pields on the form from the datatable
        /// </summary>
        private void PopulateFields()
        {
            txtDescription.Text = categories.Rows[cmbCategoryID.SelectedIndex][2].ToString();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCategorieID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoryName.SelectedIndex = cmbCategoryID.SelectedIndex;
            PopulateFields();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCategorieName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoryID.SelectedIndex = cmbCategoryName.SelectedIndex;
        }

        /// <summary>
        /// Method to bring up the form to add a category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewCategorie_Click(object sender, EventArgs e)
        {
            FrmAddCategory addCategorie = new FrmAddCategory();
            addCategorie.Text = "Add Categories";
            addCategorie.Show();
        }

        /// <summary>
        /// Method ran every time the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManageCategories_Load(object sender, EventArgs e)
        {
            categories = business.getTable("Categories");
            for (int i = 0; i < categories.Rows.Count; i++)
            {
                cmbCategoryID.Items.Add(categories.Rows[i][0].ToString());
                cmbCategoryName.Items.Add(categories.Rows[i][1].ToString());
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
            String categoryName = "";
            String description = "";
            int categoryID=0;

            if (cmbCategoryName.Text.Length > 0 && txtDescription.Text.Length > 0)
            {
                categoryID = int.Parse(cmbCategoryID.Text);
                categoryName = cmbCategoryName.Text;
                description = txtDescription.Text;
                if (business.insertData("UPDATE Categories SET CategoryName='" + categoryName + "', Description='" + description + "' WHERE CategoryID=" + categoryID, "Categories"))
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
