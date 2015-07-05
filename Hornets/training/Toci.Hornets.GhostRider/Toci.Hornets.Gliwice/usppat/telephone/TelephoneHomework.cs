using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Gliwice.usppat.telephone
{
    public class TelephoneHomework : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if (chosenOption == 1)
            {
                PhotoCommunication photo = new PhotoCommunication();
                return photo;
            }
            else
            {
                if (chosenOption == 2)
                {
                    SmsCommunication sms = new SmsCommunication();
                    return sms;
                }
                else
                {
                    if (chosenOption == 3)
                    {
                        VoiceCommunication voice = new VoiceCommunication();
                        return voice;
                    }
                    else
                    {
                        return null;
                    }
                }
            }


        }

        protected override string MyNick()
        {
            return "usppat";
        
        }
    }
}