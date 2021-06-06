using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing a person.
    /// </summary>
    public class Person
    {
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
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// Property for a person's gender.
        /// </summary>
        public string Gender { get; set; }

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
    }
}