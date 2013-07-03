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
    public partial class FrmManageEmployees : Form
    {
        private Business business;      //Object of type Business
        private DataTable employees;

        /// <summary>
        /// Constructor method for the class FrmManageEmployees
        /// </summary>
        public FrmManageEmployees()
        {
            InitializeComponent();
            business = Business.getBusiness();
        }

        /// <summary>
        /// Method to populate the pields on the form from the datatable
        /// </summary>
        private void PopulateFields()
        {
            txtLName.Text = employees.Rows[cmbEmployeeID.SelectedIndex][1].ToString();
            txtFName.Text = employees.Rows[cmbEmployeeID.SelectedIndex][2].ToString();
            txtTitle.Text = employees.Rows[cmbEmployeeID.SelectedIndex][3].ToString();
            txtCourtasy.Text = employees.Rows[cmbEmployeeID.SelectedIndex][4].ToString();
            dtpBirthDate.Value = DateTime.Parse(employees.Rows[cmbEmployeeID.SelectedIndex][5].ToString());
            dtpHireDate.Value = DateTime.Parse(employees.Rows[cmbEmployeeID.SelectedIndex][6].ToString());
            txtCity.Text = employees.Rows[cmbEmployeeID.SelectedIndex][8].ToString();
            txtAddress.Text = employees.Rows[cmbEmployeeID.SelectedIndex][7].ToString();
            txtRegion.Text = employees.Rows[cmbEmployeeID.SelectedIndex][9].ToString();
            txtPostalCode.Text = employees.Rows[cmbEmployeeID.SelectedIndex][10].ToString();
            txtCountry.Text = employees.Rows[cmbEmployeeID.SelectedIndex][11].ToString();
            txtPhone.Text = employees.Rows[cmbEmployeeID.SelectedIndex][12].ToString();
            txtExtension.Text = employees.Rows[cmbEmployeeID.SelectedIndex][13].ToString();
            txtNotes.Text = employees.Rows[cmbEmployeeID.SelectedIndex][15].ToString();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEmployeeName.SelectedIndex = cmbEmployeeID.SelectedIndex;
            PopulateFields();
        }

        /// <summary>
        /// Method to line up both combo boxes by selectedindex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEmployeeID.SelectedIndex = cmbEmployeeName.SelectedIndex;
        }

        /// <summary>
        /// Method ran every time the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManageEmployees_Load(object sender, EventArgs e)
        {  
            employees = business.getTable("Employees");
            for(int i = 0; i < employees.Rows.Count; i++)
            {
                cmbEmployeeID.Items.Add(employees.Rows[i][0].ToString());
                cmbEmployeeName.Items.Add(employees.Rows[i][2].ToString() + " " + employees.Rows[i][1].ToString());
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
        /// Method to bring up the form to add a Employee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            FrmAddEmployee addEmployee = new FrmAddEmployee();
            addEmployee.Text = "Add Employees";
            addEmployee.Show();
        }

        /// <summary>
        /// Method ran when the user selects to save changes. it sends an update
        /// querry to the database containing the info from the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            String empID = "";
            String empFName = "";
            String empLName = "";
            String title= "";
            String courtesy= "";
            String birthDate = "";
            String hireDate = "";
            String address= "";
            String postalCode= "";
            String city= "";
            String region= "";
            String country = "";
            String phone= "";
            String extension = "";
            String notes= "";

            if (cmbEmployeeID.SelectedIndex != -1 && cmbEmployeeName.SelectedIndex != -1)
            {
                empFName = txtFName.Text;
                empLName = txtLName.Text;
                title = txtTitle.Text;
                courtesy = txtCourtasy.Text;
                birthDate = dtpBirthDate.Value.ToString("dd-MMM-yyyy");
                hireDate = dtpHireDate.Value.ToString("dd-MMM-yyyy");
                address = txtAddress.Text;

                postalCode = txtPostalCode.Text;
                city = txtCity.Text;
                region = txtRegion.Text;
                country = txtCountry.Text;
                phone = txtPhone.Text;
                extension = txtExtension.Text;
                notes = txtNotes.Text;
                if (business.insertData("UPDATE Employees SET FirstName='" + empFName + "', LastName='" + empLName + "', Title='" + title + "', TitleOfCourtesy='" + courtesy + "', BirthDate='" + birthDate + "', HireDate='" + hireDate + "', Address='" + address + "', City='" + city + "', Region='" + region + "', PostalCode='" + postalCode + "', Country='" + country + "', HomePhone='" + phone + "', Extension='" + extension + "', Notes='" + notes + "' WHERE EmployeeID=" + cmbEmployeeID.Text.ToString(), "Employees"))
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
            }
        }
    }
}
