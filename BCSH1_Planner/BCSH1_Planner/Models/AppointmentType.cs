using System;

namespace BCSH1_Planner.Models;

public class AppointmentType
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Price { get; set; }
    public TimeSpan Duration { get; set; }
}