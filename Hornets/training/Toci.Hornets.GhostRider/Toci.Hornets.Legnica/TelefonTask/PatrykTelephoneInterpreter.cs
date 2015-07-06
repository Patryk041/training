using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Legnica.TelefonTask
{
    class PatrykTelephoneInterpreter : TelephoneInterpreter
    {
        private readonly Dictionary<int, Func<ITelephoneCommunication>> _telephoneCommunications = new Dictionary
            <int, Func<ITelephoneCommunication>>()
        {
            {1, () => new PhotoCommunication()},
            {2, () => new SmsCommunication()},
            {3, () =>new VoiceCommunication()}
        }; 

        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            return _telephoneCommunications.ContainsKey(chosenOption) ? _telephoneCommunications[chosenOption].Invoke() : null;
        }

        protected override string MyNick()
        {
            return "Patryk Stulczewski";
        }
    }
}
