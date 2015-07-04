using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Gliwice.Soltys
{
    public class CustomTelephoneInterpreter : TelephoneInterpreter
    {
        private const string NickName = "Sołtys";

        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
//            if (chosenOption == 1)
//            {
//                return new PhotoCommunication();
//            }
//            if (chosenOption == 2)
//            {
//                return new SmsCommunication();
//            }
//            if (chosenOption == 3)
//            {
//                return new VoiceCommunication();
//            }
//            return null;
            switch (chosenOption)
            {
                case 1:
                    return new PhotoCommunication();
                case 2:
                    return new SmsCommunication();
                case 3:
                    return new VoiceCommunication();
                default:
                    return null;
            }
        }

        protected override string MyNick()
        {
            return NickName;
        }
    }
}
