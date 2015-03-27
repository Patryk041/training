using System;

namespace InitialTrainingLibrary.Vernathic.Cyrograph
{
    public abstract class WarriorCyrographException : Exception
    {
        public abstract DateTime DeadLineTime();
    }
}
