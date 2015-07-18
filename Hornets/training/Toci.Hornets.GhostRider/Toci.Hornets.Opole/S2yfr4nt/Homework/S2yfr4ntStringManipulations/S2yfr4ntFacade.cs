using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntStringManipulations
{
    public class S2yfr4ntFacade
    {
        private StringManipulationsResults result;

        public S2yfr4ntFacade(StringManipulationsResults _result)
        {
            result = _result;
        }

        public void AllFalse()
        {
            result.IsStringInString = false;
            result.IsStringElementsInString = false;
            result.IsAnagram = false;
        }
        
        public void AllTrue()
        {
            result.IsStringInString = true;
            result.IsStringElementsInString = true;
            result.IsAnagram = true;
        }

        public void OneTrue()
        {
            result.IsStringInString = false;
            result.IsStringElementsInString = true;
            result.IsAnagram = false;
        }

        public void TwoTrue()
        {
            result.IsStringInString = true;
            result.IsStringElementsInString = true;
            result.IsAnagram = false;
        }

    }
}