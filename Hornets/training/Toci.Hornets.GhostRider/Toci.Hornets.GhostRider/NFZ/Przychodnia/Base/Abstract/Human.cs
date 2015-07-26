using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Enum;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Pacjenct.Interface;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.ResourcesRequest;

namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Abstract
{
    public abstract class Human<TAFIndex, TFeature> : IHuman<TAFIndex, TFeature>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public Dictionary<DateTime, IAddress> Addresses { get; set; }
        public Dictionary<DateTime, IContactPossibility> ContactInfoPossibilities { get; set; }

        public Dictionary<TAFIndex, IAdditionalFeature<TFeature>> AdditionalFeatures { get; set; }



    }
}