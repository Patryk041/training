using System;

namespace InitialTrainingLibrary.Vernathic.Cyrograph
{
    public class VernathicException : WarriorCyrographException
    {
        public override DateTime DeadLineTime()
        {
            const int day = 10;
            const int month = 05;
            const int year = 2015;

            return new DateTime(year,month,day);
        }
    }
}
