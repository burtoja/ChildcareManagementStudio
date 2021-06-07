using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing person information from the child care database.
    /// </summary>
    public class PersonDAL
    {
        /// <summary>
        /// Method that returns a Person object for the specified person ID.
        /// </summary>
        /// <param name="personId">The person ID of the person in question.</param>
        /// <returns>A Person object for the specified person.</returns>
        public Person GetPerson(int personId)
        {
            if (personId < 0)
            {
                throw new ArgumentException("The person ID cannot be a negative number.", "personId");
            }

            Person person = new Person();

            string selectStatement =
                "SELECT lastName, firstName, dateOfBirth, ssn, gender, phoneNumber, addressLine1, addressLine2, city, state, zipCode " +
                "FROM Person " +
                "WHERE personId = $personId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$personId", personId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            throw new ArgumentException("The specified person is not in the database.", "personId");
                        }

                        int lastNameOrdinal = reader.GetOrdinal("lastName");
                        int firstNameOrdinal = reader.GetOrdinal("firstName");
                        int dateOfBirthOrdinal = reader.GetOrdinal("dateOfBirth");
                        int ssnOrdinal = reader.GetOrdinal("ssn");
                        int genderOrdinal = reader.GetOrdinal("gender");
                        int phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");
                        int addressLine1Ordinal = reader.GetOrdinal("addressLine1");
                        int addressLine2Ordinal = reader.GetOrdinal("addressLine2");
                        int cityOrdinal = reader.GetOrdinal("city");
                        int stateOrdinal = reader.GetOrdinal("state");
                        int zipCodeOrdinal = reader.GetOrdinal("zipCode");
                        while (reader.Read())
                        {
                            person.PersonId = personId;
                            person.LastName = reader.GetString(lastNameOrdinal);
                            person.FirstName = reader.GetString(firstNameOrdinal);
                            person.DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal);
                            person.SocialSecurityNumber = reader.GetString(ssnOrdinal);
                            person.Gender = reader.GetString(genderOrdinal);
                            person.PhoneNumber = reader.GetString(phoneNumberOrdinal);
                            person.AddressLine1 = reader.GetString(addressLine1Ordinal);
                            if (!reader.IsDBNull(addressLine2Ordinal)) { person.AddressLine2 = reader.GetString(addressLine2Ordinal); }
                            person.City = reader.GetString(cityOrdinal);
                            person.State = reader.GetString(stateOrdinal);
                            person.ZipCode = reader.GetString(zipCodeOrdinal);
                        }
                    }
                }
            }

            return person;
        }
    }
}