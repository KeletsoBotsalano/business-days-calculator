using System.ComponentModel.DataAnnotations;

namespace BusinessDaysCalculator.Configuration;

public class Holiday
{
    [Required]        
    public string Name { get; set; } = string.Empty;               
    [Required]        
    public DateTime Date { get; set; }                
    public bool IsRecurring { get; set; } = false;                
    public RecurrenceType RecurrenceType { get; set; } = RecurrenceType.None;                
    public string? Description { get; set; }
}

public enum RecurrenceType
{
    None,        
    Annual,        
    Monthly,        
    Weekly
}