using BusinessDaysCalculator.Extensions;
using BusinessDaysCalculator.Models;
using BusinessDaysCalculator.Services;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessDaysCalculator.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBusinessDayCalculator(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<WorkingDayConfiguration>(configuration.GetSection("WorkingDayConfiguration"));
        services.AddSingleton<IBusinessDayCalculatorService, BusinessDayCalculatorService>();
        
        var serviceProvider = services.BuildServiceProvider();
        var calculatorService = serviceProvider.GetRequiredService<IBusinessDayCalculatorService>();
        DateTimeExtensions.ConfigureBusinessDayCalculator(calculatorService);
        
        return services;
    }
    
    public static IServiceCollection AddBusinessDayCalculator(this IServiceCollection services,            
        Action<WorkingDayConfiguration> configureOptions)        
    {
        services.Configure(configureOptions);            
        services.AddSingleton<IBusinessDayCalculatorService, BusinessDayCalculatorService>();            
        var serviceProvider = services.BuildServiceProvider();            
        var calculatorService = serviceProvider.GetRequiredService<IBusinessDayCalculatorService>();       
        DateTimeExtensions.ConfigureBusinessDayCalculator(calculatorService);           
        
        return services;        
    }
}