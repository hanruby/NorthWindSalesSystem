using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
    class Business
    {
        private static Business instance = new Business();  //Instance object of type Business.
        private DataAccessLayer data;                       //Reference object of type DataAccessLayer.
        private Dictionary<String, DataTable> tables;       //Dictionary to store the tables accessed from DataAccessLayer.

        /// <summary>
        /// Constructor method for the Business class. Gets the DataAccessLayer instance, and adds OnDataAccessChanged 
        /// to the DataAccessEventHandler.
        /// </summary>
        private Business()
        {
            data = DataAccessLayer.getDataAccessLayer();
            initVariables();
            data.DataAccess += OnDataAccessChanged;
        }

        /// <summary>
        /// Method to return the instance object of type Business.
        /// </summary>
        /// <returns>instance</returns>
        public static Business getBusiness()
        {
            return instance;
        }

        /// <summary>
        /// Initializes the table dictionary and calls the database to add each table to it.
        /// </summary>
        private void initVariables()
        {
            this.tables = new Dictionary<String, DataTable>(7);
            this.tables.Add("Categories", data.retrieveData("SELECT * FROM Categories"));
            this.tables.Add("Customers", data.retrieveData("SELECT * FROM Customers"));
            this.tables.Add("Orders", data.retrieveData("SELECT * FROM Orders"));
            this.tables.Add("Employees", data.retrieveData("SELECT * FROM Employees"));
            this.tables.Add("Products", data.retrieveData("SELECT * FROM Products"));
            this.tables.Add("Shippers", data.retrieveData("SELECT * FROM Shippers"));
            this.tables.Add("Suppliers", data.retrieveData("SELECT * FROM Suppliers"));
        }
        /// <summary>
        /// Updates the stored reference to the given table.
        /// </summary>
        /// <param name="table">Name of the table that was updated.</param>
        private void updateTable(String table)
        {
            this.tables.Remove(table); //removes the old table reference
            this.tables.Add(table, data.retrieveData("SELECT * FROM " + table)); //sets the new one
        }

        /// <summary>
        /// Gets the specified table.
        /// </summary>
        /// <param name="table">Name of the table to return</param>
        /// <returns>The stored table</returns>
        public DataTable getTable(String table)
        {
            DataTable output = null;
            this.tables.TryGetValue(table, out output); //get the table from the table dictionary
            return output;
        }

        /// <summary>
        /// Event for the DataAccessLayer being changed. Uses the table name stored in the DataAccessEventArgs to update the stored table.
        /// </summary>
        /// <param name="sender">Object that triggered the event.</param>
        /// <param name="e">DataAccessEventArgs for the event. Contants the name of the table that was updated.</param>
        public void OnDataAccessChanged(object sender, DataAccessEventArgs e)
        {
            updateTable(e.tableUpdated);
        }

        /// <summary>
        /// Inserts data to the database using the given SQL query. Also takes in the name of the table being updated.
        /// </summary>
        /// <param name="insertionString">SQL query to run .</param>
        /// <param name="table">Name of the table being updated.</param>
        /// <returns>True if the update is successful, false if not.</returns>
        public bool insertData(String insertionString, String table)
        {
            return data.insertData(insertionString, table);
        }

        /// <summary>
        /// Main method. entry point for the program.
        /// </summary>
        static void Main()
        {
            Business business = new Business(); //initialize an instance of this class
            Application.Run(new FrmParent()); //open FrmParent
        }

    }
}
