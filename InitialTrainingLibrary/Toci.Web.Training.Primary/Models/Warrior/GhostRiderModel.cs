using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Toci.Web.Training.Primary.Models.Warrior
{
    public class GhostRiderModel
    {
        public IEnumerable<SelectListItem> DropDownContent = new List<SelectListItem>
        {
            new SelectListItem() { Value = "chmura", Text = "Cloud"},
            new SelectListItem() { Value = "zaba", Text = "Frogie"},
            new SelectListItem() { Value = "sito", Text = "Net"},
            
        }; 

        public string DropDownValue { get; set; }
    }
}