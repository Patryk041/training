using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.ReferenceTypes;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.ListsOfItems
{
    public class StringList<TList, TKeys> where TList : IChainOfResponsibilityFriendly, new()
    {
        protected TList[] tablica = new TList[10];

        protected List<TList>  przyklad = new List<TList>();

        /*
         * "klucz", "wartosc"
         * "innyklucz", "wartosc"
         */

        Dictionary<int, string>  test = new Dictionary<int, string>
        {
            { 1, "dsa" },
            { 2, "dsafd" },


        };

        ///tutaj pisze logike ktora dla wyjascia spoza zakresu tablicy tworzy nowa 2 razy wieksza
        /// 
        public void Add(TList item)
        {

            test.Add(324, "xbahfvdsa");
            //test.
            ///a co jesli si enie miesci
            tablica[1] = item;

            //Func<>

            //item.Handle();
        }

        public TList[] ToList()
        {
            return tablica;
        }
    }
}
