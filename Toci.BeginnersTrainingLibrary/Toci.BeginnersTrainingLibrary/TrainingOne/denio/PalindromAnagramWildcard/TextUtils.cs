using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.PalindromAnagramWildcard
{
    public class TextUtils
    {
        

        public static bool IsPalindrom(string text)
        {
            int leng;
            string txt;
            int i;
            // radar cyc agga 
            
            txt = text;
            leng = txt.Length;



            for (i = leng/2; i > 0; i--)
            {
                if (txt[i] != txt[leng - i - 1])
                    return false;
            }

            return true;
        }

    }
}
