using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Rzeszow.KSebal.telephone
{
    public class Telephone:TelephoneInterpreter

    {
        private ITelephoneCommunication[] _sendingMethods =
        {
            new PhotoCommunication(),
            new SmsCommunication(),
            new VoiceCommunication()
        };
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            return _sendingMethods[chosenOption];
        }

        protected override string MyNick()
        {
            return "Ksebal";
        }
    }
}
