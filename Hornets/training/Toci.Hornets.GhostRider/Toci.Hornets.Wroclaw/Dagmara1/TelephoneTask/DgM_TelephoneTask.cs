using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Wroclaw.Dagmara1.TelephoneTask
{
    public class DgM_TelephoneTask : TelephoneInterpreter {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            switch (chosenOption)
            {
                case 1:
                    return new PhotoCommunication();
                case 2: 
                    return new SmsCommunication();
                case 3:
                    return new VoiceCommunication();

                default:
                    return new VoiceCommunication();
            }

            throw new System.NotImplementedException();
        }

        protected override string MyNick()
        {
            return "Dagmara";
            throw new System.NotImplementedException();
        }
    }
}