using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing position type information from the child care database.
    /// </summary>
    public class PositionTypeDAL
    {
        /// <summary>
        /// Method that returns a list of all the position types in the database.
        /// </summary>
        /// <returns>All of the position types in the database.</returns>
        public List<string> GetAllPositionTypes()
        {
            List<string> positionTypes = new List<string>();

            string selectStatement =
                "SELECT positionType " +
                "FROM PositionType";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int positionTypeOrdinal = reader.GetOrdinal("positionType");
                        while (reader.Read())
                        {
                            string currentPositionType = reader.GetString(positionTypeOrdinal);
                            positionTypes.Add(currentPositionType);
                        }
                    }
                }
            }

            return positionTypes;
        }
    }
}