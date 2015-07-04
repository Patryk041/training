using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Opole.Maly
{
    public class TelephoneTask :TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            return null;
        }

        protected override string MyNick()
        {
            return "Mały";
        }
    }
}