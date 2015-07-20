using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Wroclaw.Wudzinski.TelephoneTask
{
    public class WudzinskiTelephoneInterpreter : TelephoneInterpreter
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
            else if (chosenOption == 3)
            {
                return new VoiceCommunication();
            }
            else
            {
                return null;
            }
        }

        protected override string MyNick()
        {
            return "Wudziński";
        }
    }
}