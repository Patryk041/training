using System;
using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class CloudTypeFactory
    {
        public static Dictionary<CloudTypes, Func<ICloudType>> SpecificCloudTypes = new Dictionary<CloudTypes, Func<ICloudType>>()
        {
            {CloudTypes.Calvus, () => new CloudType("Calvus","Shape","Addictional info")},
            {CloudTypes.Capillatus,() => new CloudType("Capillatus","Shape","Addictional info")},
            {CloudTypes.Castellanus,() => new CloudType("Castellanus","Shape","Addictional info")},
            {CloudTypes.Congestus,() => new CloudType("Congestus","Shape","Addictional info")},
            {CloudTypes.Fibratus,() => new CloudType("Fibratus","Shape","Addictional info")},
            {CloudTypes.Floccus,() => new CloudType("Floccus","Shape","Addictional info")},
            {CloudTypes.Fractus,() => new CloudType("Fractus","Shape","Addictional info")},
            {CloudTypes.Humilis,() => new CloudType("Humilis","Shape","Addictional info")},
            {CloudTypes.Lenticularis,() => new CloudType("Lenticularis","Shape","Addictional info")},
            {CloudTypes.Nebulosus,() => new CloudType("Nebulosus","Shape","Addictional info")},
            {CloudTypes.Spissatus,() => new CloudType("Spissatus","Shape","Addictional info")},
            {CloudTypes.Stratiformis,() => new CloudType("Stratiformis","Shape","Addictional info")},
            {CloudTypes.Uncinus,() => new CloudType("Uncinus","Shape","Addictional info")},
            {CloudTypes.Mediocris,() => new CloudType("Mediocris","Shape","Addictional info")}
          };
    }
}