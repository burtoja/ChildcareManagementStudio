using ChildcareManagementStudio.DAL;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing credentials
    /// </summary>
    public class CredentialController
    {
        private readonly CredentialDAL credentialDAL;

        /// <summary>
        /// Constructor for CredentialController objects
        /// </summary>
        public CredentialController()
        {
            credentialDAL = new CredentialDAL();
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

            return credentialDAL.CredentialsAreValid(username, passwordHash);
        }
    }
}
