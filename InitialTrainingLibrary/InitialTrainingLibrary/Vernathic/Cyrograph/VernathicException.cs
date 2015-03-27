using System;

namespace InitialTrainingLibrary.Vernathic.Cyrograph
{
    public class VernathicException : WarriorCyrographException
    {
        public override DateTime DeadLineTime()
        {
            return new DateTime(2015,05,10);
        }
    }
}
