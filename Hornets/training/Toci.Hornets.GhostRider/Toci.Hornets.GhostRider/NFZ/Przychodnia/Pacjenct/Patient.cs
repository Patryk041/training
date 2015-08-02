using System.Collections.Generic;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Abstract;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.ResourcesRequest;

namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Pacjenct
{
    public abstract class Patient : Human<string,string,string>
    {
        public List<Symptom> Symptoms;
        public List<IAppointment> Appointments;

        protected List<Requestor<string, string>> Requestors;


        public abstract bool AddAppointment(IAppointment appointment);

    }
}