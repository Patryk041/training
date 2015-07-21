using System.Collections.Generic;
using Toci.Hornets.Sieradz.Architektura.Interfaces;

namespace Toci.Hornets.Sieradz.Architektura.Abstract
{
    public abstract class BodyPart
    {
        public readonly List<ISymptom> PossibleSymptoms;
        public readonly string BodyPartName;
    }
}