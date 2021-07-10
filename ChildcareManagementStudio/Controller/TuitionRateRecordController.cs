using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for tuition rate records.
    /// </summary>
    public class TuitionRateRecordController
    {
        private readonly TuitionRateRecordDAL tuitionRateRecordDAL;

        /// <summary>
        /// Constructor for the TuitionRateRecordController class.
        /// </summary>
        public TuitionRateRecordController()
        {
            tuitionRateRecordDAL = new TuitionRateRecordDAL();
        }

        /// <summary>
        /// Method that returns all of the tuition rate records associated with the specified student.
        /// </summary>
        /// <param name="student">The student being searched for.</param>
        /// <returns>All of the tuition rate records associated with the specified student.</returns>
        public List<TuitionRateRecord> GetTuitionRateRecords(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "The student cannot be null.");
            }

            return tuitionRateRecordDAL.GetTuitionRateRecords(student);
        }

        /// <summary>
        /// Method that returns all of the tuition rate records associated with the specified account holder.
        /// </summary>
        /// <param name="accountHolder">The account holder being searched for.</param>
        /// <returns>All of the tuition rate records associated with the specified account holder.</returns>
        public List<TuitionRateRecord> GetTuitionRateRecords(AccountHolder accountHolder)
        {
            if (accountHolder == null)
            {
                throw new ArgumentNullException("accountHolder", "The account holder cannot be null.");
            }

            return tuitionRateRecordDAL.GetTuitionRateRecords(accountHolder);
        }

        /// <summary>
        /// Method that returns all of the tuition rate records in the database.
        /// </summary>
        /// <returns>All of the tuition rate records in the database.</returns>
        public List<TuitionRateRecord> GetAllTuitionRateRecords()
        {
            return tuitionRateRecordDAL.GetAllTuitionRateRecords();
        }

        /// <summary>
        /// Method that adds a tuition rate record to the database.
        /// </summary>
        /// <param name="tuitionRateRecord">The tuition rate record to add to the database.</param>
        public void AddTuitionRateRecord(TuitionRateRecord tuitionRateRecord)
        {
            tuitionRateRecordDAL.AddTuitionRateRecord(tuitionRateRecord);
        }

        /// <summary>
        /// Method that appends an end date to an existing tuition rate record in the database.
        /// Searches for an existing record based on the student ID and start date,
        /// then edits the end date based on the end date in the revisedTuitionRateRecord argument.
        /// </summary>
        /// <param name="revisedTuitionRateRecord">The modified tuition rate record.</param>
        public void EditTuitionRateEndDate(TuitionRateRecord revisedTuitionRateRecord)
        {
            if (revisedTuitionRateRecord == null)
            {
                throw new ArgumentNullException("revisedTuitionRateRecord", "The revised tuitionRateRecord cannot be null.");
            }

            tuitionRateRecordDAL.EditTuitionRateEndDate(revisedTuitionRateRecord);
        }
    }
}