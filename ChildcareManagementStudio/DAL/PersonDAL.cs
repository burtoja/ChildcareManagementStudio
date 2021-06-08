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

        /// <summary>
        /// Method that adds a person to the database.
        /// </summary>
        /// <param name="person">
        /// A Person object representing the person to be added to the database.
        /// For the fields in the database that are set as not null, the object must have corresponding property values.
        /// Additionally, the Person object being passed to this method cannot have a value for the PersonId property since it is assigned by the database.
        /// This method completes the PersonId property for the referenced Person object after it is assigned by the database.
        /// </param>
        public void AddPerson(Person person)
        {
            if (PersonIsMissingMandatoryFields(person))
            {
                throw new ArgumentException("The Person object must have all the mandatory properties filled out.", "person");
            }

            if (person.PersonId != default)
            {
                throw new ArgumentException("The PersonId property cannot be filled out because it will be assigned by the database.", "person");
            }

            string insertStatement =
                "INSERT INTO Person (lastName, firstName, dateOfBirth, ssn, gender, phoneNumber, addressLine1, addressLine2, city, state, zipCode) " +
                "VALUES ($lastName, $firstName, $dateOfBirth, $ssn, $gender, $phoneNumber, $addressLine1, $addressLine2, $city, $state, $zipCode)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$lastName", person.LastName);
                    insertCommand.Parameters.AddWithValue("$firstName", person.FirstName);
                    insertCommand.Parameters.AddWithValue("$dateOfBirth", person.DateOfBirth);
                    insertCommand.Parameters.AddWithValue("$ssn", person.SocialSecurityNumber);
                    insertCommand.Parameters.AddWithValue("$gender", person.Gender);
                    insertCommand.Parameters.AddWithValue("$phoneNumber", person.PhoneNumber);
                    insertCommand.Parameters.AddWithValue("$addressLine1", person.AddressLine1);
                    if (person.AddressLine2 == default)
                    {
                        insertCommand.Parameters.AddWithValue("$addressLine2", DBNull.Value);
                    }
                    else
                    {
                        insertCommand.Parameters.AddWithValue("$addressLine2", person.AddressLine2);
                    }
                    insertCommand.Parameters.AddWithValue("$city", person.City);
                    insertCommand.Parameters.AddWithValue("$state", person.State);
                    insertCommand.Parameters.AddWithValue("$zipCode", person.ZipCode);
                    insertCommand.ExecuteNonQuery();
                }

                using (SqliteCommand selectCommand = new SqliteCommand("SELECT last_insert_rowid()", connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            person.PersonId = reader.GetInt32(0);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Helper method that ensures all of the mandatory properties are included with the specified Person object.
        /// </summary>
        /// <param name="person">The Person object being evaluated.</param>
        /// <returns>True if the object is missing mandatory properties, false otherwise.</returns>
        private bool PersonIsMissingMandatoryFields(Person person)
        {
            return person.LastName == default || person.FirstName == default || person.DateOfBirth == default || person.SocialSecurityNumber == default || person.Gender == default || person.PhoneNumber == default || person.PhoneNumber == default || person.AddressLine1 == default || person.City == default || person.State == default || person.ZipCode == default;
        }
    }
}