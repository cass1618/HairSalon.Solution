using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime NextAppointment { get; set; }
    public int CompletedAppointments { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}