using Toci.Hornets.GhostRider.InterfacesExtending;

namespace Toci.Hornets.GhostRider.TElephoneCommunication
{
    public class Telephone
    {
        public void Communicate(string telephoneNumber, string message, ITelephoneCommunication communication)
        {

            communication.SendInformation(message);
        }
    }
}