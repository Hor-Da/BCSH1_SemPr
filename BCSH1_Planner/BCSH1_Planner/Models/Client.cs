using System;

namespace BCSH1_Planner.Models;

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public DateTime? LastAppointment { get; set; }
}