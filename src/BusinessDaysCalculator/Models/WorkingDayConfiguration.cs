using System.ComponentModel.DataAnnotations;
using BusinessDaysCalculator.Configuration;

namespace BusinessDaysCalculator.Models;

public class WorkingDayConfiguration
{
    [Required]        
    public List<DayOfWeek> WorkingDays { get; set; } = new();             
    [Required]        
    public List<Holiday> Holidays { get; set; } = new();                
    public string TimeZone { get; set; } = TimeZoneInfo.Utc.DisplayName;              
    public bool IncludeWeekends { get; set; } = false;   
}