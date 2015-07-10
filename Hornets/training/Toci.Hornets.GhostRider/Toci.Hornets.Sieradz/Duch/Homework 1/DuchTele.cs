using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Sieradz.Duch.Homework_1
{
    public class DuchTele : TelephoneInterpreter
    {
        private readonly DuchTelephoneFactory _telephone = new DuchTelephoneFactory();

        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            return _telephone.GetInstance(chosenOption)();
        }
        
        protected override string MyNick()
        {
            return "Duch";
        }

        
    }
}
