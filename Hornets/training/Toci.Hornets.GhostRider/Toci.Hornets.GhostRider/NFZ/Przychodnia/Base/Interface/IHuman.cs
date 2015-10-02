using System;
using System.Collections.Generic;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Enum;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Pacjenct.Interface;

namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface
{
    public interface IHuman<TAFIndex, TFeature,TConntact>
    {
         string Name { get; set; } 
         string Surname { get; set; }
         DateTime BirthDate { get; set; }

         Gender Gender { get; set; }

         Dictionary<DateTime, IAddress> Addresses { get; set; }
         Dictionary<DateTime,IContactPossibility<TConntact>> ContactInfoPossibilities { get; set; }
         Dictionary<TAFIndex,IAdditionalFeature<TFeature>> AdditionalFeatures { get; set; }


    }
}