using System;

namespace Anathema.Rhonin.DataValidator
{
    public static class ValidatorYear
    {
        public static bool ValidateYear(int year)
        {

            return (year > 0 && year < DateTime.Now.Year);
        } 
    }
}