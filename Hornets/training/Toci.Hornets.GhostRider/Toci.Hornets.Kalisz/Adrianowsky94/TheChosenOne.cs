using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Kalisz.Adrianowsky94
{
    public class TheChosenOne : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            switch (chosenOption)
            {
                case 1:
                    PhotoCommunication photoCommunication = new PhotoCommunication();
                    break;
                case 2:
                    SmsCommunication smsCommunication = new SmsCommunication();
                    break;
                case 3:
                    VoiceCommunication voiceCommunication = new VoiceCommunication();
                    break;
            }
        }

        protected override string MyNick()
        {
            return "Adrianowsky94";
        }
    }
}