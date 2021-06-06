using Microsoft.Data.Sqlite;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class that can be used to get a connection to the child care database.
    /// </summary>
    public static class ChildCareDatabaseConnection
    {
        /// <summary>
        /// Method that can be used to get a connection to the child care database.
        /// </summary>
        /// <returns></returns>
        public static SqliteConnection GetConnection()
        {
            string connectionString = @"Data Source=.\ChildCareData.db;";
            SqliteConnection connection = new SqliteConnection(connectionString);
            return connection;
        }
    }
}