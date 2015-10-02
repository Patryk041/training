using System;
using System.Collections.Generic;
using Toci.Hornets.Sieradz.HealthCenter.Abstracts;

namespace Toci.Hornets.Sieradz.HealthCenter.Interfaces
{
    public interface ICalendar
    {
        //Prosze o dopisywanie wymagan osob dziedziczacych 
        bool AddAppointment(Dictionary<DateTime, Patient> calendar);
        string DoctorName { get; set; }




    }
}