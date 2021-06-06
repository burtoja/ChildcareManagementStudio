using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing a person.
    /// </summary>
    public class Person
    {
        private string socialSecurityNumber;
        private string gender;

        /// <summary>
        /// Property for a person's unique person ID.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Property for a person's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Property for a person's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Property for a person's date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Property for a person's social security number.
        /// </summary>
        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
            set
            {
                if (!IsValidSocialSecurityNumber(value))
                {
                    throw new ArgumentException("The specified social security number is not formatted properly.  A format of ###-##-#### must be used.");
                }
                socialSecurityNumber = value;
            }
        }

        /// <summary>
        /// Property for a person's gender.
        /// </summary>
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (!IsValidGender(value))
                {
                    throw new ArgumentException("The specified gender is not formatted properly.  'M' and 'F' are the only two characters that are allowed.");
                }
                gender = value;
            }
        }

        /// <summary>
        /// Property for a person's phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Property for the first line of a person's address.
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Property for the second line of a person's address.
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Property for the city that the person lives in.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Property for the state that the person lives in.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Property for the person's zip code.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Convenience property that returns a person's first and last name, separated by a space.
        /// </summary>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        /// <summary>
        /// Helper method that indicates if a social security number is formatted properly.
        /// </summary>
        /// <param name="socialSecurityNumber">The social security number being evaluated.</param>
        /// <returns>
        /// True if the social security number is formatted properly (e.g., "123-45-6789").
        /// False if the social security number is not formatted properly.
        /// </returns>
        private bool IsValidSocialSecurityNumber(string socialSecurityNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(socialSecurityNumber, @"^\d{3}-\d{2}-\d{4}$");
        }

        /// <summary>
        /// Helper method that indicates if a gender is valid.
        /// </summary>
        /// <param name="gender">The gender input being evaluated.</param>
        /// <returns>
        /// True if the gender is equal to either "M" or "F".
        /// False if the gender is not equal to either "M" or "F".
        /// </returns>
        private bool IsValidGender(string gender)
        {
            return gender.Equals("M") || gender.Equals("F");
        }
    }
}