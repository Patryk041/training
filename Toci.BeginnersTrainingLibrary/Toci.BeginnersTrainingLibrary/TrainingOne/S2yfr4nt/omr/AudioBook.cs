using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.omr
{
    class AudioBook: BookShopFeatures
    {
        protected string author;
        protected string title;
        protected int edition;
        protected int duration;

        public AudioBook(string _author, string _title, int _realeseDate, int _edition, int _duration, double _price, int _pieces)
        {
            author = _author;
            title = _title;
            realeseDate = _realeseDate;
            edition = _edition;
            duration = _duration;
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
            return new List<string> { author, title, (price * pieces).ToString() }; 
        }
    }
}
