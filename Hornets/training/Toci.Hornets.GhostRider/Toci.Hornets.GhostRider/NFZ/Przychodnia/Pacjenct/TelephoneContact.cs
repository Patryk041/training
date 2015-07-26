using Toci.Hornets.GhostRider.NFZ.Przychodnia.Pacjenct.Interface;

namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Pacjenct
{
    public class TelephoneContact :IContactPossibility
    {

        private int _phoneNumber;

        public virtual string GetContactInfo()
        {
            return _phoneNumber.ToString();
        }

        public virtual void SetPhoneNumber(int number) //=> PhoneNumber = number;
        {
            _phoneNumber = number;
        }
    }
}