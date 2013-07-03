using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SalesSystem.DatabaseManagmentForms;

/// <summary>
/// Group Project 2
/// This project is a point of sale programme for the the 
/// NorthWind database.
/// </summary>
/// <authors> Kyle Pallo, Gerald Humphries, Charaf-Eddine Khiari </authors>
/// <date> 07, December, 2012 </date>
namespace SalesSystem
{
    public partial class FrmParent : Form
    {
        private int salesFormNumber = 0;
        private Business business;

        /// <summary>
        /// Constructor for FrmParent. Gets the Business instance variable.
        /// </summary>
        public FrmParent()
        {
            InitializeComponent();
            business = Business.getBusiness();
        }

        /// <summary>
        /// Opens a new FrmSales.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmSales salesForm = new FrmSales();
            salesForm.MdiParent = this;
            salesForm.Text = "Sales Window " + salesFormNumber++;
            salesForm.Show();
        }

        /// <summary>
        /// Closes this form.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Closes all child forms
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        /// <summary>
        /// Opens a Manage Customers form.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageCustomers manageCustomers = new FrmManageCustomers();
            manageCustomers.MdiParent = this;
            manageCustomers.Text = "Manage Customers";
            manageCustomers.Show();
        }

        /// <summary>
        /// Opens a manage employees form.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageEmployees manageEmployees = new FrmManageEmployees();
            manageEmployees.MdiParent = this;
            manageEmployees.Text = "Manage Employees";
            manageEmployees.Show();
        }

        /// <summary>
        /// Opens a manage categories form.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageCategories manageCategories = new FrmManageCategories();
            manageCategories.MdiParent = this;
            manageCategories.Text = "Manage Categories";
            manageCategories.Show();
        }


        /// <summary>
        /// Opens a manage products form.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageProducts manageProducts = new FrmManageProducts();
            manageProducts.MdiParent = this;
            manageProducts.Text = "Manage Products";
            manageProducts.Show();
        }
        /// <summary>
        /// Opens a manage suppliers form.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void manageSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageSuppliers manageSuppliers = new FrmManageSuppliers();
            manageSuppliers.MdiParent = this;
            manageSuppliers.Text = "Manage Suppliers";
            manageSuppliers.Show();
        }

        /// <summary>
        /// Opens a manage shippers form.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void manageShippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageShippers manageShippers = new FrmManageShippers();
            manageShippers.MdiParent = this;
            manageShippers.Text = "Manage Shippers";
            manageShippers.Show();
        }


    }
}
