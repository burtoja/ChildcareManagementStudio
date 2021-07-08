using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing payment information from the child care database.
    /// </summary>
    public class PaymentDAL
    {
        private AccountHolderDAL accountHolderDAL;

        /// <summary>
        /// Constructor for the PaymentDAL class.
        /// </summary>
        public PaymentDAL()
        {
            accountHolderDAL = new AccountHolderDAL();
        }

        /// <summary>
        /// Method that returns all of the payments made by the specified account holder.
        /// </summary>
        /// <param name="accountHolder">The account holder in question.</param>
        /// <returns>A list of Payment objects representing all of the payments made by the specified account holder.</returns>
        public List<Payment> GetPayments(AccountHolder accountHolder)
        {
            if (accountHolder == null)
            {
                throw new ArgumentNullException("accountHolder", "The acount holder cannot be null.");
            }

            List<Payment> payments = new List<Payment>();

            string selectStatement =
                "SELECT paymentId, date, amount, type " +
                "FROM Payment " +
                "WHERE accountHolderId = $accountHolderId " +
                "ORDER BY date";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$accountHolderId", accountHolder.AccountHolderId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int paymentIdOrdinal = reader.GetOrdinal("paymentId");
                        int dateOrdinal = reader.GetOrdinal("date");
                        int amountOrdinal = reader.GetOrdinal("amount");
                        int typeOrdinal = reader.GetOrdinal("type");
                        while (reader.Read())
                        {
                            int paymentId = reader.GetInt32(paymentIdOrdinal);
                            DateTime date = reader.GetDateTime(dateOrdinal);
                            double amount = reader.GetDouble(amountOrdinal);
                            string typeString = reader.GetString(typeOrdinal).Replace(" ", "");
                            PaymentType paymentType = (PaymentType) Enum.Parse(typeof(PaymentType), typeString);

                            Payment currentPayment = new Payment
                            {
                                AccountHolder = accountHolder,
                                PaymentId = paymentId,
                                PaymentDate = date,
                                Amount = amount,
                                PaymentType = paymentType
                            };

                            payments.Add(currentPayment);
                        }
                    }
                }
            }

            return payments;
        }
    }
}