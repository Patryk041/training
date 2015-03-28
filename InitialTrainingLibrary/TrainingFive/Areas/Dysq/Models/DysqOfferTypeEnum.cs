using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingFive.Areas.Dysq.Models
{
    public static class DysqOfferTypeEnum
    {
        public enum OfferType
        {
            Wszystkie, 
            Sprzedaz, 
            Wynajem
        };

        public enum PropertyType
        {
            Mieszkania, 
            Domy, 
            Dzialki,
            Lokale, 
            Hale, 
            Obiekty
        };

        public enum City
        {
            Biala,
            Brzeg,
            Opole,
            Wroclaw,
            Warszawa
        };
    }
}