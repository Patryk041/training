using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture;

namespace TrainingFive.Models
{
    public class WarriorModel
    {
        public IEnumerable<SelectListItem> DropDownSource = new List<SelectListItem>
        {
            new SelectListItem() {Text = "Sito", Value = "net"},
            new SelectListItem() {Text = "Chmura", Value = "cloud"},
            new SelectListItem() {Text = "Emgie", Value = "mg"},
            new SelectListItem() {Text = "Dysq", Value = "disk"},
        };


        public string Name { get; set; }

        public string DropDownValue { get; set; }

        public ChmuraDepartureList<DepartureEntity> ListOfDepartures { get; set; }
    }
}