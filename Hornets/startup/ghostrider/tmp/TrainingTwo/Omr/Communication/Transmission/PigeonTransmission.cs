using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingTwo.DllShowdown;
using Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Abstraction;
using Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Interfaces;

namespace Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Transmission
{
    public class PigeonTransmission : DataTransmision
    {
        public override bool Transmit(ICommunicationMessage message)
        {
            string msg = message.GetMessage();
            //var dsq = new KlasaZBanki();

            //print
            //envelope
            //
            //msg.ToCharArray();

            return true;
        }
    }
}
