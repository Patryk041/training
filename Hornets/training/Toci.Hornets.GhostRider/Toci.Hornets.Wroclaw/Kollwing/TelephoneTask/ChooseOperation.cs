using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Wroclaw.Kollwing
{
    public class ChooseOperation : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if (chosenOption == 1)
            {
                return new PhotoCommunication();
            }



            if (chosenOption == 2)
            {
                return new SmsCommunication();
            }

            if (chosenOption == 3)
            {
                return new VoiceCommunication();
            }


            return null;
        }

        protected override string MyNick()
        {
            return "kollwing";
        }
    }
}