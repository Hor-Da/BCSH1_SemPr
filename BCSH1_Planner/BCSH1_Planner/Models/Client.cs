using System;
using System.Collections.Generic;

namespace BCSH1_Planner.Models;

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public DateTime? LastAppointment { get; set; }
    //public List<AvailabilityRule> Availability { get; set; }
    
}