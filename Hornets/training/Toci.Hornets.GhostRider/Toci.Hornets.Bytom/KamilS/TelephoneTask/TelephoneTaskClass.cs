using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;
using Toci.Hornets.GhostRider.InterfacesExtending;

namespace Toci.Hornets.Bytom.KamilS.TelephoneTask
{
    public abstract class TelephoneTaskClass : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if (chosenOption == 1)
            {
                return new PhotoCommunication(); 
            }

            else if (chosenOption == 2)
            {
                return new SmsCommunication();
            }

            else if (chosenOption == 3)
            {
                return new VoiceCommunication();   
            }
                      
            throw new System.NotImplementedException();
        }

        protected override string MyNick()
        {
            return ("KamilS");
        }

    }
    
}