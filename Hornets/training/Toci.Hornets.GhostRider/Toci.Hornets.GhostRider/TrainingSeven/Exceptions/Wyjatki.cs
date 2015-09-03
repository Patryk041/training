using System;

namespace Toci.Hornets.GhostRider.TrainingSeven.Exceptions
{
    public class Wyjatki
    {
        public void manewry()
        {
            
            throw new Exception();
        }

        public void test()
        {
            try
            {
                manewry();
            }
            catch (ApplicationException ex)
            {
                //log4net
               // ex.
                //logowanie
                throw;
            }
        }
    }
}