using System.Collections.Generic;
using SampleShowdown.Models;

namespace SampleShowdown.Areas.TeamLeasing.Models
{
    public class TeamLeasingSearchModel : GenericModel<List<TeamSearchResults>>
    {
        public string Confirm { get; set; }
        public string Duch { get; set; }
        public string Szyfrant { get; set; }
        public string Ksebal { get; set; }

        public string AleCheca { get; set; }

        public int EmployeeId { get; set; }


    }
}