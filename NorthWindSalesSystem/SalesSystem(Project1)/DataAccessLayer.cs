/// <summary>
/// Group Project 2
/// This project is a point of sale programme for the the 
/// NorthWind database.
/// </summary>
/// <authors> Kyle Pallo, Gerald Humphries, Charaf-Eddine Khiari </authors>
/// <date> 07, December, 2012 </date>

using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SalesSystem
{
    class DataAccessLayer
    {
        public event DataAccessEventHandler DataAccess;             //Delegate for the DataAccess event.
        private OleDbConnection conn;                               //OleDbConnection object to hold the connection data to connect to the database.
        private static DataAccessLayer instance = new DataAccessLayer();    //Holds theDataAccessLayer instance. A singleton pattern is used to instantiate it.

        /// <summary>
        /// Constructor method for the class DataAccessLayer.
        /// </summary>
        private DataAccessLayer()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=..\\..\\..\\Northwind.mdb;Persist Security Info=False ");
            
        }

        /// <summary>
        /// Method to return the instance object of type DataAccessLayer.
        /// </summary>
        /// <returns>The DataAccessLayer instance.</returns>
        public static DataAccessLayer getDataAccessLayer()
        {
            return instance;
        }

        /// <summary>
        /// Retrieves data from the database using a seleciton query.
        /// </summary>
        /// <param name="selectionString">SQL selection query.</param>
        /// <returns>Datatable containing the retrieved data.</returns>
        public DataTable retrieveData(String selectionString)
        {
            DataTable dt = new DataTable();
            // using the Application variable from now on



            OleDbCommand cm = new OleDbCommand(selectionString, conn);

            // Using a DataAdapter and a DataSet here to see another way. 
            // This could be done with a DataReader as well
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cm;
            DataSet ds = new DataSet();

            // Open the connection, fill the DataSet and get out
            //conn.Open();
            da.Fill(ds);

            da.Dispose();  // May not be necessary but does help prepare for Garbage Collection
            conn.Close();

            // Make sure we have the data we expect
            // i.e. at least a single row of data
            if (ds.Tables[0].Columns.Count != 0 &&
                ds.Tables[0].Rows.Count != 0)
            {
                dt = ds.Tables[0];
            }

            return dt;
        }

        /// <summary>
        /// Method to insert new data into a table in the database. 
        /// Takes an SQL query and the name of the table the query affects. Triggers the OnDataAccess 
        /// event if the SQL query is successful.
        /// </summary>
        /// <param name="insertionString">SQL query</param>
        /// <param name="table">Name of the table being update/inserted into.</param>
        /// <returns>True if successful, false if not.</returns>
        public bool insertData(String insertionString, String table)
        {
            OleDbCommand cm = new OleDbCommand(insertionString, conn);
            try
            {
                conn.Open();
                cm.ExecuteNonQuery();
                OnDataAccess(table); //trigger event
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Event trigger for the DataAccess Event.
        /// </summary>
        /// <param name="table">Name of the table that was updated</param>
        protected virtual void OnDataAccess(String table)
        {
            DataAccessEventHandler handler = DataAccess;
            if (handler != null)
            {
                //Invokes the delegates.
                handler(this, new DataAccessEventArgs()
                {
                    tableUpdated = table
                });
            }
        }
    }
}