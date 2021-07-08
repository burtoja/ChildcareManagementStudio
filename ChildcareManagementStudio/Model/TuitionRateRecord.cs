using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class for recording the amount of tuition that an
    /// account holder owes within a date range as a result
    /// of a given student being enrolled.
    /// </summary>
    public class TuitionRateRecord
    {
        /// <summary>
        /// The account holder responsible for payment.
        /// </summary>
        public AccountHolder AccountHolder { get; set; }

        /// <summary>
        /// The student that is enrolled.
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// The date when the rate went into effect.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The date when the rate stopped being active.
        /// This is an optional property.
        /// If a student is actively enrolled at this rate,
        /// the end date will equal the default DateTime value.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The daily amount of tuition that is owed by the
        /// account holder as a result of the student
        /// being enrolled.
        /// </summary>
        public double DailyRate { get; set; }
    }
}