using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingFive.Areas.Mg.Models
{
    public static class MgOfferTypeEnum
    {

        public enum OfferType { All, Sale, Rent }

        public enum PropertyType { All, Flat, House, Ground, Premis, Hall, Object }

        public enum City { Opole, Wroclaw, Warszawa }

        public enum NumberOfRooms { All, One, Two, Three, Four, FiveOrMore }
    }
}