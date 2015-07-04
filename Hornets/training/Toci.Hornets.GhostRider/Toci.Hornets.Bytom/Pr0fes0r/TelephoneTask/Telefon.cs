using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Bytom.Pr0fes0r.TelephoneTask
{
    public class Telefon : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            switch (chosenOption)
            {
                case 1: { return new PhotoCommunication();}
                case 2: { return new SmsCommunication();}
                case 3:
                {
                    return new VoiceCommunication();
                }
                default:break;
                }
            }
        }

        protected override string MyNick()
        {
            return "Pr0fes0r";
        }
    }
}