using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingFour.Exceptions
{
    class WarriorSpecificException : WarriorException
    {
        public WarriorSpecificException(string customMessage, string internalMessageToLog) : base(customMessage, internalMessageToLog)
        {
        }
    }
}
