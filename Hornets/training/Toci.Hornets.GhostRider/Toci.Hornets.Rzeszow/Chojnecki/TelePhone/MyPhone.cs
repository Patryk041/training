using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Rzeszow.Chojnecki.TelePhone
{
    public class MyPhone : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if (chosenOption == 1) return new PhotoCommunication();
            if (chosenOption == 2) return new SmsCommunication();
            if (chosenOption == 3) return new VoiceCommunication();
            throw new System.NotImplementedException();
        }
        protected override string MyNick()
        {
            return "Król Albani";
        }
    }
}