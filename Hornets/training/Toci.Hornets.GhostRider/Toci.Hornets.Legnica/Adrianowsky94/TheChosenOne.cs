using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Legnica.Adrianowsky94
{
    public class TheChosenOne : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            ITelephoneCommunication communication = null;
            switch (chosenOption)
            {
                case 1:
                    communication = new PhotoCommunication();
                    break;
                case 2:
                    communication = new SmsCommunication();
                    break;
                case 3:
                    communication = new VoiceCommunication();
                    break;
            }

            return communication;
        }

        protected override string MyNick()
        {
            return "Adrianowsky94";
        }
    }
}