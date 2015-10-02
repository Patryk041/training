using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface
{
    public interface ICalendar
    {
        bool AddAppointment(IAppointment appointment);
        List<IAppointment> GetAvalaibleAppointments();
    }
}