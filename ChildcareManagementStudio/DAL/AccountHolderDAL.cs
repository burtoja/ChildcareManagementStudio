using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing account holder information from the child care database.
    /// </summary>
    public class AccountHolderDAL : PersonDAL
    {
        /// <summary>
        /// Method that returns AccountHolder objects for all of the account holders in the database.
        /// </summary>
        /// <returns>A list of AccountHolder objects for all of the account holders in the database.</returns>
        public List<AccountHolder> GetAllAccountHolders()
        {
            List<AccountHolder> accountHolders = new List<AccountHolder>();

            string selectStatement =
                "SELECT ah.personId, ah.accountHolderId " +
                "FROM AccountHolder ah " +
                "JOIN Person p ON ah.personId = p.personId " +
                "ORDER BY p.lastName, p.firstName";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int accountHolderIdOrdinal = reader.GetOrdinal("accountHolderId");
                        while (reader.Read())
                        {
                            AccountHolder accountHolder = new AccountHolder
                            {
                                PersonId = reader.GetInt32(personIdOrdinal),
                                AccountHolderId = reader.GetInt32(accountHolderIdOrdinal)
                            };

                            Person person = GetPerson(accountHolder.PersonId);
                            accountHolder.LastName = person.LastName;
                            accountHolder.FirstName = person.FirstName;
                            accountHolder.DateOfBirth = person.DateOfBirth;
                            accountHolder.SocialSecurityNumber = person.SocialSecurityNumber;
                            accountHolder.Gender = person.Gender;
                            accountHolder.PhoneNumber = person.PhoneNumber;
                            accountHolder.AddressLine1 = person.AddressLine1;
                            if (person.AddressLine2 != default) { accountHolder.AddressLine2 = person.AddressLine2; }
                            accountHolder.City = person.City;
                            accountHolder.State = person.State;
                            accountHolder.ZipCode = person.ZipCode;

                            accountHolders.Add(accountHolder);
                        }
                    }
                }
            }

            return accountHolders;
        }
    }
}