using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Zly
{
   public class YearValidation
   {
       private int _year;

       public YearValidation(int year)
       {
           _year = year;
       }

       public bool IsYearLeap()
       {
           return ((_year%4 == 0 && _year%100 != 0) || _year%400 == 0);

       }

       public bool Validate()
       {
           return _year > 0;
       }

       }

    }

