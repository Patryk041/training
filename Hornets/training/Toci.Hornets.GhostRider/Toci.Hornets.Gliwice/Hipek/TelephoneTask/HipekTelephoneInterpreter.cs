using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Gliwice.Hipek.TelephoneTask
{
    public class HipekTelephoneInterpreter : TelephoneInterpreter
    {
        private readonly Dictionary<int, ITelephoneCommunication> _communicationMap = new Dictionary<int, ITelephoneCommunication>
        {
            {1, new PhotoCommunication()},
            {2, new SmsCommunication()},
            {3, new VoiceCommunication()}
        }; 

        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            return _communicationMap.ContainsKey(chosenOption) ? _communicationMap[chosenOption] : null;
        }

        protected override string MyNick()
        {
            return "Hipek - Gliwice";
        }
    }
}
