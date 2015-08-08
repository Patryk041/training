namespace Toci.Hornets.Bytom.Szary.TrainingTwo.StringTask
{
    public class Stringi
    {
        public bool CharInWord(char[] subject, char[] seek)
        {
            var lenghtsubject = subject.Length;
            var lenghtseek = seek.Length;
            var sumcontrol = lenghtseek;

            for (var i = 0; i < lenghtsubject; i++)
            {
                for (var j = 0; j < lenghtseek; j++)
                {
                    if (subject[i] != seek[j]) continue;
                    sumcontrol = sumcontrol - 1;
                    break;
                }
                if (sumcontrol == 0)
                {
                    return true;

                }
            }
            return false;

        } 
    }
}