using System;

namespace BCSH1_Planner.Models;

public class AvailabilityRule
{
    public DayOfWeek DayOfWeek { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
}