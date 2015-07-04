using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Opole.Maly
{
    public class TelephoneTask :TelephoneInterpreter
    {
        protected override string ChooseMedium(int chosenOption)
        {
            switch (chosenOption)
            {
                case 1:
                    return "../photo.jpg";
                case 2:
                    return "To jest sms od Małego";
                case 3:
                    return "lallallal";
            }
        }

        protected override string MyNick()
        {
            return "Mały";
        }
    }
}