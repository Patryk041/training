using System;
using System.Collections.Generic;
using Toci.Hornets.Sieradz.Architektura.Enums;
using Toci.Hornets.Sieradz.Architektura.Interfaces;

namespace Toci.Hornets.Sieradz.Architektura.Abstract
{
    public abstract class Disease
    {
        
        protected List<ISymptom> ListOfSymptoms;
        protected Dictionary<GenderEnum, int[]> GenderToAgeRelation;
        
        public string DiseaseName;

        public virtual bool DoesAgeAndGenderMatch(GenderEnum gender, int age)
        {
            return GenderToAgeRelation[gender][0] <= age && GenderToAgeRelation[gender][1] >= age;
        }

    }
}