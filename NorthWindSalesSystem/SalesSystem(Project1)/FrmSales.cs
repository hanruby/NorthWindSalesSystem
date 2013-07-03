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
/// <authors> Kyle Pallo, Gerald Humphries, Charaf-Eddine Khiari </authors>
/// <date> 07, December, 2012 </date>
namespace SalesSystem
{
    public partial class FrmSales : Form
    {
        private Business business;

        /// <summary>
        /// Constructor for FrmSales. Sets the business instance variable to the Business singleton instance.
        /// </summary>
        public FrmSales()
        {
            InitializeComponent();
            business = Business.getBusiness();
        }

        /// <summary>
        /// IndexChanged event for cmbCustomerID. Changes the index of cmbCustomerName to match.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomerName.SelectedIndex = cmbCustomerID.SelectedIndex;
        }

        /// <summary>
        /// IndexChanged event for cmbCustomerName. Changes the index of cmbCustomerID to match.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomerID.SelectedIndex = cmbCustomerName.SelectedIndex;
        }

        /// <summary>
        /// Click event for btnAddItem. Instantiates and shows an instance of FrmCatalogue.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FrmCatalogue catalogue = new FrmCatalogue(this);
            catalogue.MdiParent = this.MdiParent;
            catalogue.Show();
        }

        /// <summary>
        /// Click event for btnComplete. Builds several SQL queries based on user input, then sends them to insertData in Business.
        /// Shows a messagebox that says "Success" if successful and closes this form, otherwise it tells the user to fill in all required fields.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void btnComplete_Click(object sender, EventArgs e)
        {
            //instantiate variables to store user input and data from the database
            String customerID = "";
            int employeeID = 4;
            DateTime orderDate = DateTime.Now;
            DateTime requiredDate = new DateTime(0);
            DateTime shippedDate = new DateTime(0);
            String shipVia = "";
            int freight = 0;
            String shipName = "";
            String shipAddress = "";
            String shipCity = "";
            String shipRegion = "";
            String shipPostalCode = "";
            String shipCountry = "";

            int orderID = 0;
            int productID = 0;
            decimal unitPrice = 0;
            int quantity = 0;
            int discount = 0;

            DataRow customerRow;
            DataRow employeeRow;
            DataRow shipperRow;
            DataRow orderRow;


            bool quantityEntered = false;

            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (int.Parse(row.Cells[7].Value.ToString()) > 0)
                {
                    quantityEntered = true; //check to make sure the user has entered at least one quantity
                }
            }

            //make sure an item has been added to dgvOrderDetails, an employee has been selected, a customer has been selected, and at least one quantity has been filled out
            if (cmbCustomerID.SelectedIndex != -1 && cmbEmployees.SelectedIndex != -1 && dgvOrderDetails.Rows.Count > 0 && quantityEntered)
            {
                customerID = cmbCustomerID.Text.ToString();
                employeeID = int.Parse(cmbEmployees.Text.ToString().Substring(0, 1));
                customerRow = business.getTable("Customers").Select("CustomerId = '" + customerID + "'")[0]; //get the customerID database entry
                employeeRow = business.getTable("Employees").Select("EmployeeId = " + employeeID)[0]; //employee entry
                shipperRow = business.getTable("Shippers").Select("ShipperId = " + 3)[0]; //shippers entry

                //fill some of the data variables using the retrieved rows
                shipVia = shipperRow[1].ToString();
                freight = 10;
                shipName = customerRow[1].ToString();
                shipAddress = customerRow[4].ToString();
                shipCity = customerRow[5].ToString();
                shipPostalCode = customerRow[7].ToString();
                shipCountry = customerRow[8].ToString();

                //build the Orders insertion string using the retrieved data and some entered data
                String oInsertionString = "INSERT INTO Orders "
                    + "(CustomerID, EmployeeID, OrderDate, ShipName, "
                    + "ShipAddress, ShipCity, ShipPostalCode, ShipCountry) "
                    + "VALUES ('" + customerID + "', " + employeeID + ", '" + orderDate.ToString("dd-MMM-yyyy") + "', '"
                    + shipName + "', '" + shipAddress + "', '" + shipCity + "', '"
                    + shipPostalCode + "', '" + shipCountry + "')";
                business.insertData(oInsertionString, "Orders"); //run the query

                //get the id of the last row in the orders table (the one that was just inserted) and initialize a String array to store each insertion query for Order Details
                String[] odInsertionString = new String[dgvOrderDetails.Rows.Count];
                orderRow = business.getTable("Orders").Rows[business.getTable("Orders").Rows.Count - 1];
                orderID = int.Parse(orderRow[0].ToString());

                //build each insertion string
                for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    productID = int.Parse(dgvOrderDetails.Rows[i].Cells[0].Value.ToString());
                    unitPrice = decimal.Parse(dgvOrderDetails.Rows[i].Cells[5].Value.ToString());
                    quantity = int.Parse(dgvOrderDetails.Rows[i].Cells[7].Value.ToString());
                    discount = 0;
                    if (quantity > 0) //make sure a valid above 0 quantity has been entered before building and using the string
                    {
                        odInsertionString[i] = "INSERT INTO [Order Details] VALUES (" + orderID
                            + ", " + productID + ", " + unitPrice + ", " + quantity + ", " + discount + ")";
                        business.insertData(odInsertionString[i], "Order Details"); //insert the row
                    }
                }
                MessageBox.Show("Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }

        }

        /// <summary>
        /// Click event for btnClear. Runs clearForm() to clear the form.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        /// <summary>
        /// Load event for FrmSales. Fills the comboboxes with data from the database
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void FrmSales_Load(object sender, EventArgs e)
        {
            updateClock();

            DataTable clerks = business.getTable("Employees");
            DataTable customers = business.getTable("Customers");


            for (int i = 0; i < clerks.Rows.Count; i++)
            {
                //add the employees for the employee combobox by their ID and full name.
                cmbEmployees.Items.Add(clerks.Rows[i][0].ToString() + ": " + clerks.Rows[i][2].ToString() + " " + clerks.Rows[i][1].ToString());
            }
            for (int i = 0; i < customers.Rows.Count; i++)
            {
                //fill the customer comboboxes with the appropriate data
                cmbCustomerID.Items.Add(customers.Rows[i][0].ToString());
                cmbCustomerName.Items.Add(customers.Rows[i][1].ToString());
            }
        }

        /// <summary>
        /// Method to add products to the datagrid. Uses an array of DataGridViewRow that it was passed to fill dgvOrderDetails.
        /// </summary>
        /// <param name="selectedProducts">array of DataGridViewRow containing a row for each selected product</param>
        public void addProduct(DataGridViewRow[] selectedProducts)
        {
            foreach (DataGridViewRow row in selectedProducts) //loop for every selected row
            {

                if (getSelectedProductIndexByID(int.Parse(row.Cells[0].Value.ToString())) == -1) //make sure the product isn't already added
                {
                    DataGridViewRow rowToAdd = new DataGridViewRow(); //instantiate a new DataGridViewRow
                    rowToAdd.CreateCells(dgvOrderDetails); //create cells using dgvOrderDetails as a template
                    for (int i = 0; i < 7; i++)
                    {
                        rowToAdd.Cells[i].Value = row.Cells[i].Value; //add data from the current passed in row to the row that's using the dgvOrderDetails template
                    }
                    dgvOrderDetails.Rows.Add(rowToAdd); //add the row to dgvOrderDetails
                }
            }
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                row.Cells[7].Value = 0; //set the quantity of every row to 0
            }
        }

        /// <summary>
        /// Clears the form.
        /// </summary>
        private void clearForm()
        {
            cmbEmployees.SelectedIndex = -1;
            cmbCustomerName.SelectedIndex = -1;
            cmbCustomerID.SelectedIndex = -1;
            dgvOrderDetails.Rows.Clear();
        }

        /// <summary>
        /// Updates lblDateTime to the current date/time.
        /// </summary>
        private void updateClock()
        {
            lblDateTime.Text = DateTime.Now.Date.ToShortDateString()
                + "    " + DateTime.Now.ToShortTimeString();
        }

        /// <summary>
        /// CellEndEdit event for dgvOrderDetails. Parses the value of every quantity cell in order to update the totals and taxes.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void dgvOrderDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                int quantity = 0;
                int id = int.Parse(dgvOrderDetails.Rows[i].Cells[0].Value.ToString()); //parse the id
                if (dgvOrderDetails.Rows[i].Cells[7].Value != null && !dgvOrderDetails.Rows[i].Cells[7].Value.ToString().Equals("")) //make sure the quantity cell isn't null or blank
                {
                    if (int.TryParse(dgvOrderDetails.Rows[i].Cells[7].Value.ToString(), out quantity)) //try to parse the quantity
                    {
                        if (quantity <= int.Parse(dgvOrderDetails.Rows[i].Cells[6].Value.ToString())) //parse the unit price
                        {
                            //mulptiply the unit price by the quantity to get the extended price
                            dgvOrderDetails.Rows[i].Cells[8].Value = (quantity * double.Parse(dgvOrderDetails.Rows[i].Cells[5].Value.ToString())).ToString();
                        }
                        else
                        {
                            //set the value of quantity to 0 if the parse fails to avoid an exception
                            dgvOrderDetails.Rows[i].Cells[7].Value = 0;
                            MessageBox.Show("Quantity is not available");
                        }
                    }
                }
                else
                {
                    //set the value of quantity to 0 if the parse fails to avoid an exception
                    dgvOrderDetails.Rows[i].Cells[7].Value = 0;
                }
            }

            double subtotal = 0;
            double gst = 0;
            double pst = 0;
            double total;

            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                double ext = 0;
                if (dgvOrderDetails.Rows[i].Cells[8].Value != null)
                {
                    //calculate the subtotal by adding up every exended price
                    double.TryParse(dgvOrderDetails.Rows[i].Cells[8].Value.ToString(), out ext);
                }
                subtotal += ext;
            }

            //calculate the taxes and total, then set the labels to display them
            gst = subtotal * 0.07;
            pst = subtotal * 0.08;
            total = subtotal + gst + pst;

            lblSubOut.Text = subtotal.ToString("C");
            lblGSTOut.Text = gst.ToString("C");
            lblPSTOut.Text = pst.ToString("C");
            lblTotalOut.Text = total.ToString("C");
        }

        /// <summary>
        /// Tick event for timer1. Runs updateClock() to update the clock label once every second.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateClock();
        }

        /// <summary>
        /// CellBeginEdit for dgvOrderDetails. Erases the value in the quantity cell to prompt the user to type.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">EventArgs for the event.</param>
        private void dgvOrderDetails_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvOrderDetails.SelectedRows[0].Cells[7].Value = "";
        }

        /// <summary>
        /// Takes an ID and searches dgvOrderDetails for the index of the product that has that ID. Returns -1 if
        /// it's not found. May be used to check for duplicates before entering products.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private int getSelectedProductIndexByID(int id)
        {
            int output = -1;

            for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
            {
                if (id == int.Parse(dgvOrderDetails.Rows[i].Cells[0].Value.ToString()))
                {
                    output = i;
                }
            }
            return output;

        }

    }
}

