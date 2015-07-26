using System.Collections.Generic;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface;

namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Abstract
{
    public abstract class Symptom : ISymptom
    {
        public string Name { get; set; }
        public List<IBodyPart> BodyParts;

    }
}