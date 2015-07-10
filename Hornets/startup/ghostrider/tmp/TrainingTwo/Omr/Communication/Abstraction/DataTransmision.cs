using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Interfaces;

namespace Toci.Hornets.GhostRider.TrainingTwo.Omr.Communication.Abstraction
{
    public abstract class DataTransmision
    {
        public abstract bool Transmit(ICommunicationMessage message);
    }
}
