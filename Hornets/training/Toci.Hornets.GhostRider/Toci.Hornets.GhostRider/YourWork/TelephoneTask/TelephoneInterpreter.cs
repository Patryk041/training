using System.Diagnostics;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;

namespace Toci.Hornets.GhostRider.YourWork.TelephoneTask
{
    public abstract class TelephoneInterpreter
    {
        private int tosieniedziedziczy;
        public void GetUserChoice(int chosenOption)
        {
            ITelephoneCommunication communication = ChooseMedium(chosenOption);

            if (communication == null)
            {
                Debug.WriteLine("{0} has not  created {1} for {2}", MyNick(), "type :D ", chosenOption);
                return;
            }

            tosieniedziedziczy = 8;

            Telephone phone = new Telephone();

            phone.Communicate("570751507", "czesc", communication);

            Debug.WriteLine("{0} has created {1} for {2}", MyNick(), communication.GetType(), chosenOption);
            //communication.SendInformation()
        }

        protected abstract ITelephoneCommunication ChooseMedium(int chosenOption);// dla 1 - photo, 2 - sms, 3 voice
        
        protected abstract string MyNick();
    }
}