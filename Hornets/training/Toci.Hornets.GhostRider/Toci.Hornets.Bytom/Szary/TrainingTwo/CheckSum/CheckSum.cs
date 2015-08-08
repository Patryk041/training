namespace Toci.Hornets.Bytom.Szary.TrainingTwo.CheckSum
{
    public class CheckSum
    {
        public int Suma(string pesel)
        {
            var sum = 0;
            // a+3b+7c+9d+e+3f+7g+9h+i+3j+k
            var peselchar = pesel.ToCharArray();
            int[] controlnumbers = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
            var peselnumbers = new int[peselchar.Length];
            for (var i = 0; i < 11; i++)
            {
                sum = controlnumbers[i] * peselnumbers[i] + sum;
            }
            return sum;
        } 
    }
}