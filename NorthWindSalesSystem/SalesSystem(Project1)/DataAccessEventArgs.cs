using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    /// DataAccessEventArgs class. Contants the name of the table that was updated.
    /// </summary>
    public class DataAccessEventArgs : EventArgs
    {
        public String tableUpdated;
    }
}
