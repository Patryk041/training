namespace Anathema.Rhonin.DataValidator
{
    public static class ValidatorMonth
    {
        public static bool ValidateMonth(int month)
        {
            return ((month > 0) && (month < 13)) ? true : false;
        } 
    }
}