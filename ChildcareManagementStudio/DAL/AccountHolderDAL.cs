using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
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

        /// <summary>
        /// Method that adds the specified account holder to the database.
        /// </summary>
        /// <param name="accountHolder">
        /// AccountHolder object representing the account holder to add.
        /// The AccountHolder object cannot have a value for the AccountHolderId property, since this will be assigned by the database.
        /// </param>
        public void AddAccountHolder(AccountHolder accountHolder)
        {
            if (accountHolder.AccountHolderId != default)
            {
                throw new ArgumentException("The AccountHolderId property cannot be filled out because it will be assigned by the database.", "accountHolder");
            }

            // TODO: wrap the table updates in a transaction

            AddPerson(accountHolder);

            string insertStatement =
                "INSERT INTO AccountHolder (personId) " +
                "VALUES ($personId)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$personId", accountHolder.PersonId);
                    insertCommand.ExecuteNonQuery();
                }

                using (SqliteCommand selectCommand = new SqliteCommand("SELECT last_insert_rowid()", connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accountHolder.AccountHolderId = reader.GetInt32(0);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Method that edits an employee's records in the database.
        /// </summary>
        /// <param name="originalAccountHolder">AccountHolder object representing the account holder's records before the edits are made.</param>
        /// <param name="revisedAccountHolder">AccountHolder object representing the account holder's records after the edits are made.</param>
        public void EditAccountHolder(AccountHolder originalAccountHolder, AccountHolder revisedAccountHolder)
        {
            if (originalAccountHolder == null)
            {
                throw new ArgumentNullException("originalAccountHolder", "The original account holder cannot be null.");
            }

            if (revisedAccountHolder == null)
            {
                throw new ArgumentNullException("revisedAccountHolder", "The revised account holder cannot be null.");
            }

            if (originalAccountHolder.AccountHolderId != revisedAccountHolder.AccountHolderId)
            {
                throw new ArgumentException("The account holder ID must be the same for both AccountHolder objects.");
            }

            EditPerson(originalAccountHolder, revisedAccountHolder);
        }
    }
}