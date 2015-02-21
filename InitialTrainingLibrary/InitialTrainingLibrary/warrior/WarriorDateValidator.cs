using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.warrior
{
    public class WarriorDateValidator : IDateValidator
    {
        public bool DateValidate(int year, int month, int day)
        {
            return true;
        }

        public string GetName()
        {
            return "Warrior";
        }
    }
}
