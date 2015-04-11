using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingFive.Areas.Soltys.Models
{
    public class SearchFormModel
    {
        public int SelectedOfferType { get; set; }
        public int SelectedPropertyType { get; set; }
        public int SelectedPlace { get; set; }
        public int MinSurface { get; set; }
        public int MaxSurface { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public int OfferNumber { get; set; }

        public IEnumerable<SelectListItem> PlacesList { get; set; }
    }
}