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

        /// <summary>
        /// The number of days in the date range.
        /// The start and end dates are included in the count if they are weekdays.
        /// If the TuitionRateRecord has an end date, that date is used for the count.
        /// If the TuitionRateRecord does not have an end date, the current date is used for the count.
        /// </summary>
        public int NumberOfWeekdaysInRange
        {
            get
            {
                DateTime endDate;
                if (this.EndDate == default)
                {
                    endDate = DateTime.Now;
                }
                else
                {
                    endDate = this.EndDate;
                }

                return this.NumberOfWeekdaysBetweenDates(this.StartDate, endDate);
            }
        }

        private int NumberOfWeekdaysBetweenDates(DateTime startDate, DateTime endDate)
        {
            int dowStart = ((int)startDate.DayOfWeek == 0 ? 7 : (int)startDate.DayOfWeek);
            int dowEnd = ((int)endDate.DayOfWeek == 0 ? 7 : (int)endDate.DayOfWeek);
            TimeSpan timeSpan = endDate - startDate;
            if (dowStart <= dowEnd)
            {
                return (((timeSpan.Days / 7) * 5) + Math.Max((Math.Min((dowEnd + 1), 6) - dowStart), 0));
            }
            return (((timeSpan.Days / 7) * 5) + Math.Min((dowEnd + 6) - Math.Min(dowStart, 6), 5));
        }
    }
}