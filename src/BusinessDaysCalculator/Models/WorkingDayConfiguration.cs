using System.ComponentModel.DataAnnotations;

namespace BusinessDaysCalculator.Configuration;

public class WorkingDayConfiguration
{
    [Required]        
    public List<DayOfWeek> WorkingDays { get; set; } = new();             
    [Required]        
    public List<Holiday> Holidays { get; set; } = new();                
    public string TimeZone { get; set; } = "UTC";              
    public bool IncludeWeekends { get; set; } = false;   
}