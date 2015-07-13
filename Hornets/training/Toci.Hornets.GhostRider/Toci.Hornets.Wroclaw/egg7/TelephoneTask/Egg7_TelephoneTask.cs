using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Wroclaw.egg7.TelephoneTask
{
    class Egg7_TelephoneTask : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChoseMedium(int chosenOption)
        {
            switch (chosenOption)
            {
                case 1 : 
                    return new PhotoCommunication();
                case 2 :
                    return new SmsCommunication();
                case 3 :
                    return new VoiceCommunication();
                default :
                    return null;
            }
        }
        protected override string MyNick()
        {
            return "kollwing";
        }
    }
}
