namespace BusinessDaysCalculator.Configuration;

public class BusinessDayResult
{
    public DateTime Date { get; set; }        
    public bool IsWorkingDay { get; set; }        
    public string? Reason { get; set; }        
    public Holiday? Holiday { get; set; }
}