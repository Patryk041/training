using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Chmura.ChmuraInheritanceTask;

namespace Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture
{
    public class ChmuraDepartureValidation<T> where T : DepartureEntity
    {
        private DepartureEntity _departure;
        private DepartureList<T> _list;

        public ChmuraDepartureValidation(DepartureList<T> myEntity, DepartureEntity myList )
        {
            this._list = myEntity;
            this._departure = myList;
        }

        public static Dictionary<string, Func<DepartureEntity, DepartureList<T>, bool>> ValidationTasks = new ChmuraStringDictionary<Func<DepartureEntity, DepartureList<T>, bool>>
        {
            {"Check if dates are overall correct", (x, y) => ChmuraDepartureHelpers<T>.CheckCorrectnessOfDates(x)},
            {"Validate the date", (x, y) => ChmuraDepartureHelpers<T>.ValidateTheDate(x)},
            {"If Section has proper Client", (x, y) => ChmuraDepartureHelpers<T>.CheckSection(x)},
            {"Check if dates overlaps", ChmuraDepartureHelpers<T>.DateOverlaps},
            {"Validate the status", ChmuraDepartureHelpers<T>.CheckStatus}
        };
       }
}
