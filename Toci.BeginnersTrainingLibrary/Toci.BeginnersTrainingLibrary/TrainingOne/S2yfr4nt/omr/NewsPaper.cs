using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.omr
{
    class NewsPaper : BookShopFeatures
    {
        public string newsPaperName;
        public string header;

        public NewsPaper(string _newsPaperName, string _header, int _realeseDate, double _price, int _pieces)
        {
            newsPaperName = _newsPaperName;
            header = _header;
            realeseDate = _realeseDate;
            price = _price;
            pieces = _pieces;
        }

        public override List<string> GetInformation()
        {
            throw new NotImplementedException();
        }

        public override void GetInformation(string path)
        {
            throw new NotImplementedException();
        }

        public override List<string> BillInformation()
        {
            return new List<string> { newsPaperName, header, (price * pieces).ToString() }; 
        }
    }
}
