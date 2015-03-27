using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingFive.Areas.Dysq.Models
{
    public class DysqFindOfferModel
    {
        public DysqOfferTypeEnum.OfferType OfferType;
        public DysqOfferTypeEnum.PropertyType PropertyType;
        public DysqOfferTypeEnum.City City;

        public float MinArea { get; set; }
        public float MaxArea { get; set; }

        public float MinPrice { get; set; }
        public float MaxPrice { get; set; }

        public int OfferNumber { get; set; }

    }
}