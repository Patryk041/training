using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Sieradz.DeeJay.TelephoneTask
{
    public class DjTelephoneCommunication : TelephoneInterpreter
    {
        private readonly DjTelephoneFactory _djTelephoneFactory = new DjTelephoneFactory();

        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            var chosenMedium = _djTelephoneFactory.GetInstance(chosenOption);
            return chosenMedium != null ? chosenMedium() : null;
        }

        protected override string MyNick()
        {
            return "DeeJay";
        }
    }
}