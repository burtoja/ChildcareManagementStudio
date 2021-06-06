using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing credentials
    /// </summary>
    class CredentialController
    {
        /// <summary>
        /// Constructor for CredentialController objects
        /// </summary>
        public CredentialController()
        {
        }

        /// <summary>
        /// Method for checking if the specified credentials are valid.
        /// </summary>
        /// <param name="username">The username being checked.</param>
        /// <param name="passwordHash">The sha256 password hash being checked.</param>
        /// <returns>True if the specified credentials are valid.  False if the specified credentials are invalid.</returns>
        public bool CredentialsAreValid(string username, string passwordHash)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(""));
                string emptyStringHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                if (passwordHash == emptyStringHash)
                {
                    throw new ArgumentNullException("password", "The password cannot be null or empty.");
                }
            }

            return true; //TODO: Replace -- This is a placeholder until DB/DAL is implemented
        }
    }
}
