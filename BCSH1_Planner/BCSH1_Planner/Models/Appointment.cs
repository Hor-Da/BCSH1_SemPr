namespace BCSH1_Planner.Models;

public class Appointment
{
    public  int Id { get; set; }
    public int ClientId { get; set; }
    public AppointmentType Type { get; set; }
}