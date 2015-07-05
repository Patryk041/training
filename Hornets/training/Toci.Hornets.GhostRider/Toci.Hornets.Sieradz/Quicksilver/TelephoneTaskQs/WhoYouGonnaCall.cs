using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Sieradz.Quicksilver.TelephoneTaskQs
{
    class WhoYouGonnaCall : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {

            if (chosenOption == 1)
                return new PhotoCommunication();
            if(chosenOption ==2)
                return new SmsCommunication();
            if(chosenOption ==3)
                return new VoiceCommunication();
            
                return null;

            
        }

        protected override string MyNick()
        {

            return "Quicksilver";
            
        }
    }
}
