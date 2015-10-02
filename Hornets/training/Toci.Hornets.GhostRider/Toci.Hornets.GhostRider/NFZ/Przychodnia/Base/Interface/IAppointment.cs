using System;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Enum;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Pacjenct.Interface;

namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface
{
    public interface IAppointment
    {
         DateTime AppointmaDate { get; set; } 
         IAddress Address { get; set; }

         AppointmentType AppointmentType { get; set; }
    }
}