using System.Collections.Generic;
using Toci.Hornets.Legnica.zadania_grupowe.WebMD.@enum;

namespace Toci.Hornets.Legnica.zadania_grupowe.WebMD.Data
{
    public class PatientInforamtion
    {
        public List<BodyPart> BodyParts { get; set; }

        public string Name{ get; set; }

        public int Age{ get; set; }

        public Gender Gender{ get; set; }
    }
}