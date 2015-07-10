using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Abstraction;
using Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Interfaces;

namespace Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Transmission
{
    public class InternetTransmission : DataTransmision
    {
        public override bool Transmit(ICommunicationMessage message)
        {
            //Socket s = new Socket();

            return true;
        }
    }
}
