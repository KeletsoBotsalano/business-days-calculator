using BusinessDaysCalculator.Services;

namespace BusinessDaysCalculator.Extensions;

public static class DateTimeExtensions
{
    private static IBusinessDayCalculatorService? _calculatorService;

    public static void ConfigureBusinessDayCalculator(IBusinessDayCalculatorService calculatorService)
    {
        _calculatorService = calculatorService ?? throw new ArgumentNullException(nameof(calculatorService));
    }
}