using System;
using System.Collections.Generic;
using Toci.Hornets.Sieradz.HealthCenter.Abstracts;
using Toci.Hornets.Sieradz.HealthCenter.Interfaces;

namespace Toci.Hornets.Sieradz.Przychodnia.Types
{
    public class Calendar :ICalendar
    {
        public Dictionary<DateTime, Patient> AppointmentCalendar;
        public bool AddAppointment(Dictionary<DateTime, Patient> calendar)
        {
            throw new NotImplementedException();
        }

        public string DoctorName { get; set; }
    }
}