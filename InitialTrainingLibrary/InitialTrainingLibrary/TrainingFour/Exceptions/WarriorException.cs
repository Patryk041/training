using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingFour.Exceptions
{
    public class WarriorException : WarriorExceptionBase
    {
        public WarriorException(string customMessage, string internalMessageToLog) : base(customMessage, internalMessageToLog)
        {
        }
    }
}
