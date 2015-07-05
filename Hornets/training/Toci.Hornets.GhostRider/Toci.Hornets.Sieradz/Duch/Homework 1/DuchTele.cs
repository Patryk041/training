using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.Sieradz.Duch.Homework_1
{
    public class DuchTele : TelephoneInterpreter
    {

        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            var aaa = new DuchTelephoneFactory();
            
            return aaa.GetInstance(chosenOption)();
        }

        protected override string MyNick()
        {
            return "Duch";
        }

        
    }
}
