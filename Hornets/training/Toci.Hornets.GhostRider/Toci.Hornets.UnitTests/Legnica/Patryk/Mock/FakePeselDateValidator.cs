using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.Interfaces;

namespace Toci.Hornets.UnitTests.Legnica.Patryk.Mock
{
    public class FakePeselDateValidator : IDateValidator
    {
        public bool ValidateDate(int year, int month, int day)
        {
            return true;
        }
    }
}