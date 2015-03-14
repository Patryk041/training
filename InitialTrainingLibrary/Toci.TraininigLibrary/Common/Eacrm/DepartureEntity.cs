using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Common.Eacrm
{
    public abstract class DepartureEntity
    {
        protected static Dictionary<int, List<int>> ClientsList = new Dictionary<int, List<int>>()
        {
            { 1, new List<int> {1,2,3,4} },
            { 2, new List<int> {5,6,7} },
            { 3, new List<int> {8,9,10} },
            { 4, new List<int> {11,12,13,14} },
        };

        public virtual int ClientId { get; set; }

        public virtual int SectionId { get; set; } // mozna walidowac czy sectionid przynalezy do danego klienta

        public int Id { get; set; }

        public virtual DateTime DepartureDate { get; set; }

        public virtual DateTime ReturnDate { get; set; }

        public abstract int WeeksCount { get; }

        public virtual int ConsultantId { get; set; }

        public virtual int StatusId { get; set; } // 1 active 2 departuring 3 experienced 4 inadequate 5 new 6 revisiting
    }

    /*
     * Zasady biznesowe do zaimplementowania:
     * - data wyjazdu nie moze byc dalsza od daty powrotu
     * - kolejne rekordy wyjazdow nie moga sie zazebiac w kolekcji
     * - dla kazdego klient id powinna istniec lista section id, dane section id powinno zawsze odpowiadac mapowaniu na client id
     * - slownik odpowiedzialny za client id i section id to ClientsList
     * - statusy poszczegolnych wyjazdow prezentuja sie nastepujaco:
     *    - 1 - active - tylko dla rekordu z interwalem czasowym wyjazd w przeszlosci, powrot w przyszlosci
     *    - 2 - departuring - tylko dla rekordu, ktory date wyjazdu ma max za 7 dni, ale generalnie w przyszlosci
     *    - 3 - experienced - dla rekordu z datami w przeszlosci, info ze pracowal u klienta o danym klient id i ma tam doswiadczenie
     *    - 4 - inadequate - dla rekordu zatrudnienia w przeszlosci, gdzie osoba ma zakaz powrotu. istnienie takiego rekordu w kolekcji oznacza, ze nie da sie dodac nowego rekordu dla tego klienta
     *    - 5 - new - osoba jest 1 raz umowiona do danego klienta, jest wiecej niz 7 bdni przed odjazdem
     *    - 6 - revisiting - ten status ma osoba, ktora jest wiecej niz 7 dni przed odjazdem i istnieje rekord ze statusem experienced w kolekcji dla danego klient id
     */
}
