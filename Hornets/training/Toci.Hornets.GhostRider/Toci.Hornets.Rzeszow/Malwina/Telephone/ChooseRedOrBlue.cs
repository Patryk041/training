using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Rzeszow.Malwina.Telephone
{
    public class ChooseRedOrBlue : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
          if (chosenOption == 1)
          { return new PhotoCommunication();}

          if (chosenOption == 2)
          { return new SmsCommunication();}

            if (chosenOption == 3)
            { return new VoiceCommunication();}
        }

        protected override string MyNick()
        {
            string m = "Malwi";
            return m;
        }
    }
}