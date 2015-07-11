using System;

namespace Toci.Hornets.Bytom.AdamP.TaskTrainingTwo
{
    public class PeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        protected override bool Checksum(string pesel)
        {
            if (String.IsNullOrEmpty(pesel) || pesel.Length > 11)
            {
                throw new System.ArgumentNullException();
            }
            else
            {
                int[] Weights = { 1, 3, 7, 9 };
                int Sum = 0;

                for (int peselCounter = 0, weightsCounter = 0; peselCounter < 10; peselCounter++, weightsCounter++)
                {
                    if (weightsCounter > 3) weightsCounter = 0;
                    Sum += Weights[weightsCounter] * int.Parse(pesel.Substring(peselCounter, 1));
                }

                int LastNumber = int.Parse(pesel.Substring(10, 1));

                int ControlValue = Sum % 10;

                if (ControlValue == 0)
                {
                    return (LastNumber == 0);
                }
                else
                {
                    return (LastNumber == (10 - ControlValue));
                }
            }
        }

        protected override bool ValidateDate(int year, int month, int day)
        {

            throw new System.NotImplementedException();
        }

        public override string GetNick()
        {
            return "AdamP";
        }

        public override bool IsPeselValid(string pesel)
        {
            throw new System.NotImplementedException();
        }
    }
}