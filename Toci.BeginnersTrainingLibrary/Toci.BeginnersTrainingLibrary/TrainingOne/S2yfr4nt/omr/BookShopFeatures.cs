using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.omr
{
    public abstract class BookShopFeatures
    {

        protected int realeseDate;
        protected double price;
        protected int pieces;

        public abstract string[] GetInformation();
        public abstract void GetInformation(string path);
        public abstract string[] BillInformation();


    }


}
