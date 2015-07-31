using System;
using System.Collections.Generic;
using System.Linq;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface;

namespace Toci.Hornets.Rzeszow.Terry.NFZ
{
    public class LocalCalendar : ICalendar
    {
        protected Dictionary<DateTime, IAppointment> AppointmentsDictionary = new Dictionary<DateTime, IAppointment>();  
        public bool AddAppointment(IAppointment appointment)
        {
            if (AppointmentsDictionary.ContainsValue(appointment)) return false;
         
            AppointmentsDictionary.Add(appointment.AppointmaDate, appointment);
            return true;
        }

        public List<IAppointment> GetAvalaibleAppointments()
        {
           return AppointmentsDictionary.Keys.Select(date => AppointmentsDictionary[date]).ToList();
        }
    }
}