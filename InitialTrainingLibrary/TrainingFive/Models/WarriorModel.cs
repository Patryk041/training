using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Dal.Models;
using Toci.Db.Interfaces;
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

        public Dictionary<string, string> Lista = new Dictionary<string, string>
        {
            {"dsafasd", "dsafasd"},
            {"gh", "dsafasd"},
            {"gfehfd", "dsafasd"},
            {"fjdksgo", "dsafasd"},
            {"fjdsgos", "dsafasd"},
            {"fdsj", "dsafasd"},
            {"fndwjg", "dsafasd"},
            {"htrerghd", "fnhewdwbngh"},
            {"fndjgdwws", "dsafasd"},
            {"dsafgadsgdsfgh", "6tyghfffds"},
            {"fjuiogdsngs", "dsafasd"},
            {"fmidgojdsf", "dsafasd"},
            {"fjsorewg", "dsafasd"},
            {"dsafafjdwioguesd", "dsafasd"},
        }; 

        public string Name { get; set; }

        public string GhostRider { get; set; }

        public string DropDownValue { get; set; }

        public DataSet TransferLists { get; set; }

        public ChmuraDepartureList<DepartureEntity> ListOfDepartures { get; set; }

        public List<IModel> TransferList { get; set; } 
    }
}