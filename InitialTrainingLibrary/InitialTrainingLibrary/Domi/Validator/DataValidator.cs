using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.Domi.Validator
{
   public class DataValidator : IDateValidator
   {
       public int day;
       public int month;
       public int year;

      
       LogicValidator data = new LogicValidator();
           
       public bool DateValidate(int year, int month, int day)
       {
           data = new LogicValidator(year, month, day);
           data.CheckDay();
           data.CheckMonth();
           data.CheckYear(); 
           return true;
       }

       public string GetName()
       {
           return "Domi"; 
       }
    }
}
