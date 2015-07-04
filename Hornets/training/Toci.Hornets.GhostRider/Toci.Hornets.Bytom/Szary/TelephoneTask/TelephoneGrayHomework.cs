using System;
using System.Diagnostics;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Bytom.Szary.TelephoneTask
{
    public class TelephoneGrayHomework : TelephoneInterpreter
    {

        protected override GhostRider.InterfacesExtending.ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if(chosenOption==1)
                return new PhotoCommunication();
            else if(chosenOption==2)
                return new SmsCommunication();
            else if(chosenOption==3)
                return new VoiceCommunication();
            else
            {
                Debug.WriteLine("Wrong number of option choosen");
            }
            throw new System.NotImplementedException();
        }

        protected override string MyNick()
        {
            return ("Szary");
        }

    }
}