using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Bytom.AdamP.TelephoneTask
{
    class TelephoneTaskChooser : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if (chosenOption == 1)
            {
                return new PhotoCommunication();
            }
            else
            {
                if (chosenOption == 2)
                {
                    return new SmsCommunication();
                }
                else
                {
                    if (chosenOption == 3)
                    {
                        return new VoiceCommunication();
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                }
            }
           
        }

        protected override string MyNick()
        {
            return "AdamP";
        }
    }
}
