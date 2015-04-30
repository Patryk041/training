using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Rubi.TextUtils.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Rubi.TextUtils
{
    class Palindrom:IPalindrom
    {
        public bool CheckPalindrom(string palindrom)
        {
            return palindrom == palindrom.Reverse();
        }
    }
}
