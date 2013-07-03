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
    /// Delegate for DataAccessEvent.
    /// </summary>
    /// <param name="sender">Object that triggered the event.</param>
    /// <param name="e">DataAccessEventArgs for the event. Contants the name of the table that was updated.</param>
    public delegate void DataAccessEventHandler(object sender, DataAccessEventArgs e);
}