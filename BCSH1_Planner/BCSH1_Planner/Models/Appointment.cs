using System;

namespace BCSH1_Planner.Models;

public class Appointment
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public AppointmentType Type { get; set; }
}