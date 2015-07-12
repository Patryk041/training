using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Gliwice.Rudi
{
    public class RudiTelephoneInterpreter : TelephoneInterpreter
    {

        protected override ITelephoneCommunication ChooseMedium(int choosenOption)
        {

            switch (choosenOption)
            {
                case 1:
                    return new PhotoCommunication();
                case 2:
                    return new SmsCommunication();
                case 3:
                    return new VoiceCommunication();
                default:
                    return null;
            }
        }

        protected override string MyNick()
        {
            return "Rudi";
        }
    }
}
