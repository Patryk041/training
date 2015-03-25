using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingFive.Areas.Mg.Models
{
    public class MgFindOfferModel
    {
        public MgOfferTypeEnum.OfferType offerType;
        public MgOfferTypeEnum.PropertyType propertyType;
        public MgOfferTypeEnum.City city;
        public MgOfferTypeEnum.NumberOfRooms numberOfRooms;
    }
}