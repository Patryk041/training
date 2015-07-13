namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.String
{
    public class Stringi
    {
        public bool CharInWord(char[] subject, char[] seek)
        {
            int lenghtsubject = subject.Length;
            int lenghtseek = seek.Length;
            int sumcontrol = lenghtseek;
            
            for (int i = 0; i < lenghtsubject; i++)
            {
                for (int j = 0; j < lenghtseek; j++)
                {
                    if (subject[i] == seek[j])
                    {
                        sumcontrol = sumcontrol - 1;
                        break;
                    }
                }
                if (sumcontrol == 0)
                {
                    return true;
                    break;
                }
            }
            return false;

        }
    }
}