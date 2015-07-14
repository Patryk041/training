using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Opole.S2yfr4nt.TelephoneHomework
{
    public class S2yfr4ntTelephoneInterpreter: TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            return telephoneCommunications.ContainsKey(chosenOption)? telephoneCommunications[chosenOption](): null;
        }

        protected override string MyNick()
        {
            return "S2yfr4nt";
        }

        private Dictionary<int, Func<ITelephoneCommunication>> telephoneCommunications = new Dictionary<int, Func<ITelephoneCommunication>>()
        {
            {1, () => new PhotoCommunication()},
            {2, () => new SmsCommunication()},
            {3, () => new VoiceCommunication()}
        };
    }
}