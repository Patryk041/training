using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.Interfaces;

namespace Toci.Hornets.UnitTests.Legnica.Patryk.Mock
{
    public class FakeChecksumValidator : IChecksumValidator
    {
        public bool ValidateChecksum(string str)
        {
            return true;
        }
    }
}