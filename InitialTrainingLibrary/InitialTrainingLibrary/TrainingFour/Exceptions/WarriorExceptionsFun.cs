using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingFour.Exceptions
{
    public class WarriorExceptionsFun
    {
        public void FunWithExceptions()
        {
            try
            {
                //throw new WarriorExceptionBase("", "");
            }

            catch (WarriorException)
            {

            }

            catch (WarriorExceptionBase ex)
            {
                var test = ex.StackTrace;
            }
            catch (Exception)
            {

            }
            finally
            {
                
            }
        }
    }
}
