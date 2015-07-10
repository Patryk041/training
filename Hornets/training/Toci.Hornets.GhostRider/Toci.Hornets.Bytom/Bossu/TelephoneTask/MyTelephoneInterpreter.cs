
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Toci.Hornets.GhostRider.YourWork.TelephoneTask;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.InterfacesExtending;


namespace Toci.Hornets.Bytom.Bossu.TelephoneTask
{
    public class MyTelephoneInterpreter : TelephoneInterpreter
    {
        // dla 1 - photo, 2 - sms, 3 voice
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if (chosenOption == 1)
            {
                return new PhotoCommunication();
            }

            if (chosenOption == 2)
            {
                return new SmsCommunication();
            }

            if (chosenOption == 3)
            {
                return new VoiceCommunication();
            }

            throw new InvalidOperationException(String.Format("Invalid chosen option: {0}", chosenOption));
        }

        protected override string MyNick()
        {
            return "Bossu";
        }
    }
}
