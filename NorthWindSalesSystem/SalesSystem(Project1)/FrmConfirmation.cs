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
    /// <summary>
    /// Class for the Confirmation form. Not enough time to use it :(
    /// </summary>
    public partial class FrmConfirmation : Form
    {
        public FrmConfirmation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
