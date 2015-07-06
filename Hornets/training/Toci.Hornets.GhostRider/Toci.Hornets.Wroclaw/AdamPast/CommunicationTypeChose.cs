using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Wroclaw.AdamPast
{
    public class CommunicationTypeChose : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if (chosenOption == 1)
            {
                return new PhotoCommunication();
            }
            else if (chosenOption == 2)
            {
                return new SmsCommunication();
            }
            else 
            {
                return new VoiceCommunication();
            }
            //else
            //{
            //    return "unknown communication type";
            //}
        }

        protected override string MyNick()
        {
            return "gipson";
        }
    }
}