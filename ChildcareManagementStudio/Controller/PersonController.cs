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
    }
}