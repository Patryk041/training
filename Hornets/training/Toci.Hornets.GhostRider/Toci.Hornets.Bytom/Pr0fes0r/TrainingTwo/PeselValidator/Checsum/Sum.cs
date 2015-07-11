namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.PeselValidator.Checsum
{
    public class Sum
    {
        public int Suma(string pesel)
        {
            int sum = 0;
            // a+3b+7c+9d+e+3f+7g+9h+i+3j+k
            char [] peselchar = pesel.ToCharArray();
            int[] controlnumbers = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1};
            int[] peselnumbers = new int[peselchar.Length];
            for (int i = 0 ; i < 11; i++)
            {
                sum = controlnumbers[i]*peselnumbers[i] + sum;
            }

            return sum;
            
            
        }
    }
}