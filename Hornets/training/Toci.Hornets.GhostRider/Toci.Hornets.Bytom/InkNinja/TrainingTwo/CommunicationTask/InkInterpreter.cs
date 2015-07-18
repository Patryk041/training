using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Bytom.InkNinja.TrainingTwo.CommunicationTask
{
    class InkInterpreter : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            ITelephoneCommunication communication;
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
                default:
                    communication = null;
                    break;
            }
            return communication;           
           
        }

        protected override string MyNick()
        {
            return "InkNinja";
        }
    }
}
