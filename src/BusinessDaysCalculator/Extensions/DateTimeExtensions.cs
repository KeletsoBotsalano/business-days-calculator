using BusinessDaysCalculator.Services;

namespace BusinessDaysCalculator.Extensions
{
    public static class DateTimeExtensions
    {
        private static IBusinessDayCalculatorService? _calculatorService;

        public static void ConfigureBusinessDayCalculator(IBusinessDayCalculatorService calculatorService)
        {
            _calculatorService = calculatorService ?? throw new ArgumentNullException(nameof(calculatorService));
        }

        public static bool IsWorkingDay(this DateTime date)
        {
            EnsureServiceConfigured();
            return _calculatorService!.IsWorkingDay(date);
        }

        public static DateTime AddWorkingDays(this DateTime date, int workingDays)
        {
            EnsureServiceConfigured();
            return _calculatorService!.AddWorkingDays(date, workingDays);
        }

        public static DateTime SubtractWorkingDays(this DateTime date, int workingDays)
        {
            EnsureServiceConfigured();
            return _calculatorService!.SubtractWorkingDays(date, workingDays);
        }

        public static DateTime GetNextWorkingDay(this DateTime date)
        {
            EnsureServiceConfigured();
            return _calculatorService!.GetNextWorkingDay(date);
        }

        public static DateTime GetPreviousWorkingDay(this DateTime date)
        {
            EnsureServiceConfigured();
            return _calculatorService!.GetPreviousWorkingDay(date);
        }

        public static int GetWorkingDaysBetween(this DateTime startDate, DateTime endDate)
        {
            EnsureServiceConfigured();
            return _calculatorService!.GetWorkingDaysBetween(startDate, endDate);
        }

        private static void EnsureServiceConfigured()
        {
            if (_calculatorService == null)
                throw new InvalidOperationException("Business day calculator service has not been configured. Call ConfigureBusinessDayCalculator first.");
        }
    }
}