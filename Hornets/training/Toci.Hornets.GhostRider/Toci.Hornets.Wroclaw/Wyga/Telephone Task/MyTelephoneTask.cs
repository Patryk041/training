using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;
using Toci.Hornets.Wroclaw.Kollwing;

namespace Toci.Hornets.Wroclaw.Wyga.Telephone_Task
{
    class MyTelephoneTask : TelephoneInterpreter
    {


        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if(chosenOption ==1)
                return new PhotoCommunication();
            if(chosenOption == 2)
                return new SmsCommunication();
            if(chosenOption == 3)
                return  new VoiceCommunication();

          throw new Exception("Chosen option is invalid");
        }

        protected override string MyNick()
        {
            return "Wyga";
        }
    }
}
