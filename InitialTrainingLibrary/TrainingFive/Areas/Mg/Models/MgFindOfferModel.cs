using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingFive.Areas.Mg.Models
{
    public class MgFindOfferModel
    {
        public MgOfferTypeEnum.OfferType OfferType;
        public MgOfferTypeEnum.PropertyType PropertyType;
        public MgOfferTypeEnum.City City;
        public MgOfferTypeEnum.NumberOfRooms NumberOfRooms;

        public float MinArea { get; set; }
        public float MaxArea { get; set; }

        public float MinPrice { get; set; }
        public float MaxPrice{ get; set; }

        public int OfferId{ get; set; }
    }
}