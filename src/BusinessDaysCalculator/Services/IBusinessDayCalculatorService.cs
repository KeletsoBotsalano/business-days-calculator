using BusinessDaysCalculator.Models;

namespace BusinessDaysCalculator.Services
{
    public interface IBusinessDayCalculatorService
    {
        /// <summary>
        /// Checks if a given date is a working day
        /// </summary>
        bool IsWorkingDay(DateTime date);
        
        /// <summary>
        /// Gets detailed information about a date
        /// </summary>
        BusinessDayResult GetBusinessDayInfo(DateTime date);
        
        /// <summary>
        /// Adds specified number of working days to a date
        /// </summary>
        DateTime AddWorkingDays(DateTime startDate, int workingDays);
        
        /// <summary>
        /// Subtracts specified number of working days from a date
        /// </summary>
        DateTime SubtractWorkingDays(DateTime startDate, int workingDays);
        
        /// <summary>
        /// Calculates the number of working days between two dates
        /// </summary>
        int GetWorkingDaysBetween(DateTime startDate, DateTime endDate);
        
        /// <summary>
        /// Gets the next working day from the specified date
        /// </summary>
        DateTime GetNextWorkingDay(DateTime date);
        
        /// <summary>
        /// Gets the previous working day from the specified date
        /// </summary>
        DateTime GetPreviousWorkingDay(DateTime date);
        
        /// <summary>
        /// Gets all working days in a given date range
        /// </summary>
        List<DateTime> GetWorkingDaysInRange(DateTime startDate, DateTime endDate);
        
        /// <summary>
        /// Gets all holidays in a given year
        /// </summary>
        List<Holiday> GetHolidaysInYear(int year);
    }
}