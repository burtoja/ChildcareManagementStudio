using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing people.
    /// </summary>
    public class PersonController
    {
        private readonly PersonDAL personDAL;

        /// <summary>
        /// Constructor for the PersonController class.
        /// </summary>
        public PersonController()
        {
            personDAL = new PersonDAL();
        }

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

            return personDAL.GetPerson(personId);
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

            personDAL.AddPerson(person);
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