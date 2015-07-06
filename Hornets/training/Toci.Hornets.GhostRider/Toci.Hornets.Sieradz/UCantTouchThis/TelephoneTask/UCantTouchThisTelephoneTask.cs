using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Sieradz.UCantTouchThis.TelephoneTask
{
    public class UCantTouchThisTelephoneTask : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            return UCTT_TelephoneTaskFactory.GetInstance(chosenOption);
        }

        protected override string MyNick()
        {
            return "UCantTouchThis";
        }
    }
}