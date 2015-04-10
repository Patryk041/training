using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.omr
{
    class Book: BookShopFeatures
    {
        protected string author;
        protected string title;
        protected int edition;
        protected int pageNr;


        public Book(string _author, string _title, int _realeseDate, int _edition, int _pageNr, double _price, int _pieces)
        {
            author = _author;
            title = _title;
            realeseDate = _realeseDate;
            edition = _edition;
            pageNr = _pageNr;
            price = _price;
            pieces = _pieces;
        }


        public override string[] GetInformation()
        {
            throw new NotImplementedException();
        }

        public override void GetInformation(string path)
        {
            throw new NotImplementedException();
        }

        public override string[] BillInformation()
        {
            return new string[] { author, title, (price * pieces).ToString() }; 
        }


    }
}
