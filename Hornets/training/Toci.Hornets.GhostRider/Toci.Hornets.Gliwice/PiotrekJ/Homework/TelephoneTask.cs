using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Gliwice.PiotrekJ.Homework
{
    public class TelephoneTask : TelephoneInterpreter
    {
        /*protected override ITelephoneCommunication ChoseMedium(int chosenOption)
        {
            if chosenOption =  1
            return 1;


        }

        protected override string MyNick()
        {
        
            return "PiotrekJ";
        }
        */
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            throw new System.NotImplementedException();
        }

        protected override string MyNick()
        {
            throw new System.NotImplementedException();
        }
    }
}