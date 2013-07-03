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
    public partial class FrmManageShippers : Form
    {
        private Business business;      //Object of type Business
        private DataTable shippers;

        /// <summary>
        /// Constructor method for the class FrmManageShippers
        /// </summary>
        public FrmManageShippers()
        {
            InitializeComponent();
            business = Business.getBusiness();
        }

        /// <summary>
        /// Method to populate the pields on the form from the datatable
        /// </summary>
        private void PopulateFields()
        {
           txtPhone.Text = shippers.Rows[cboShipperID.SelectedIndex][2].ToString();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboShipperID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboShipperName.SelectedIndex = cboShipperID.SelectedIndex;
            PopulateFields();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboShipperName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboShipperID.SelectedIndex = cboShipperName.SelectedIndex;
            PopulateFields();
        }

        /// <summary>
        /// Method ran every time the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManageShippers_Load(object sender, EventArgs e)
        {
            shippers = business.getTable("Shippers");
            for(int i = 0; i < shippers.Rows.Count; i++)
            {
                cboShipperID.Items.Add(shippers.Rows[i][0].ToString());
                cboShipperName.Items.Add(shippers.Rows[i][1].ToString());
            }
        }

        /// <summary>
        /// Method to bring up the form to add a shipper.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewShipper_Click(object sender, EventArgs e)
        {
            FrmAddShipper addShipper = new FrmAddShipper();
            addShipper.Text = "Add Shipper";
            addShipper.Show();
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
            String companyName = "";
            String phone = "";
            if (cboShipperID.SelectedIndex != -1)
            {
                companyName = cboShipperName.Text.ToString();
                phone = txtPhone.Text.ToString();
                if (business.insertData("UPDATE Shippers SET CompanyName='" + companyName + "', Phone='" + phone + "' WHERE ShipperID=" + cboShipperID.Text.ToString(), "Shippers")) 
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
            }
        }
    }
}
