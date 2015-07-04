using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Rzeszow.Polak.TelephoneTask1
{
    public class TelephoneTask1: TelephoneInterpreter
    {
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
            else return new SmsCommunication();

            // OR...

            //switch (chosenOption)
            //{
            //    case 1:
            //        return  new PhotoCommunication();
            //    case 2:
            //        return new SmsCommunication();
            //    case 3:
            //        return  new VoiceCommunication();
                    
            //        //chyba tak ma to być :P
            //}

        }

        protected override string MyNick()
        {
            return "Polak";
        }
    }
}