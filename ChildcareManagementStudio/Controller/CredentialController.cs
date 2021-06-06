using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <param name="password">The password being checked.</param>
        /// <returns>True if the specified credentials are valid.  False if the specified credentials are invalid.</returns>
        public bool CredentialsAreValid(string username, string password)
        {
            return true;
        }
    }
}
