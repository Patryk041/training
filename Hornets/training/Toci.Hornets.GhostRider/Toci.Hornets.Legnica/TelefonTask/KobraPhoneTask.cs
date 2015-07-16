using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Legnica.TelefonTask
{
    public class KobraPhoneTask : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if(chosenOption == 1) return new VoiceCommunication();
            if(chosenOption == 2) return new SmsCommunication();
            if (chosenOption == 3) return new PhotoCommunication();
            return null;
        }

        protected override string MyNick()
        {
            return "Kobra";
        }
    }
}