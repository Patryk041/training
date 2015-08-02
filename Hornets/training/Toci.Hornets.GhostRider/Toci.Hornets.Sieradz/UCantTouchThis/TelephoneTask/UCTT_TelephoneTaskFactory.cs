using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;

namespace Toci.Hornets.Sieradz.UCantTouchThis.TelephoneTask
{
    public static class UCTT_TelephoneTaskFactory
    {
        private static Dictionary<int, Func<ITelephoneCommunication>> TelephoneFactory = new Dictionary
            <int, Func<ITelephoneCommunication>>
        {
            {1, () => new PhotoCommunication()},
            {2, () => new SmsCommunication()},
            {3, () => new VoiceCommunication()}
        };

        public static ITelephoneCommunication GetInstance(int chosenOption)
        {
            return TelephoneFactory.ContainsKey(chosenOption) ? TelephoneFactory[chosenOption]() : null;
        }
    }
}