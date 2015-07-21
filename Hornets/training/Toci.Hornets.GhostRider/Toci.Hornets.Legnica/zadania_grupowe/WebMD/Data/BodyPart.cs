using System.Collections.Generic;
using Toci.Hornets.Legnica.zadania_grupowe.WebMD.@enum;

namespace Toci.Hornets.Legnica.zadania_grupowe.WebMD.Data
{
    public class BodyPart
    {
        public List<Symptom> Symptoms { get; set; }

        public BodyPartName Name{ get; set; }
    }
}