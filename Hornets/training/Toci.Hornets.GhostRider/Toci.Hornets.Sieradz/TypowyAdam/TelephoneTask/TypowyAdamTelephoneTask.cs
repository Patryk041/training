using System.Collections.Generic;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Sieradz.TypowyAdam.TelephoneTask
{
    public class TypowyAdamTelephoneTask
    {
        public class TypowyAdamTelphoneTask : TelephoneInterpreter
        {
            protected override ITelephoneCommunication ChooseMedium(int chosenOption)
            {
                Dictionary<int, ITelephoneCommunication> objects =
                    new Dictionary<int, ITelephoneCommunication>()
                {
                    {3, new VoiceCommunication()},
                    {2, new SmsCommunication()},
                    {1, new PhotoCommunication()}
                };
                return objects[chosenOption];
            }

            protected override string MyNick()
            {
                return "TypowyAdam";
            }
        } 
    }
}