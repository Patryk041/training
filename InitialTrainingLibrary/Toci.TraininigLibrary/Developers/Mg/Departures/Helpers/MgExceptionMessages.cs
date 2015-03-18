using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Mg.Departures.Helpers
{
    public static class MgExceptionMessages
    {

        public static readonly string DepartureDateIsLaterThanTheReturnDate = "Departure date is later than the return date";
        public static readonly string DepartureDateOverlapsTheDateOfReturn = "Departure date overlaps the date of return";
        public static readonly string SectionIdIsNotValidForThisClientId = "Section ID is not valid for this client ID";

        public static readonly string ThisPersonIsAlreadyBack = "This person is already back";
        public static readonly string DpeartureDateIsLongerThanSevenDaysFromNow = "Departure time is longer than 7 days from now";
        public static readonly string ThisPersonIsNotBackYet = "This person is not back yet";

    }
}
