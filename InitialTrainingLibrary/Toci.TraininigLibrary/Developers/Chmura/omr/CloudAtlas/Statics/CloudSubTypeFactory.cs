using System;
using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class CloudSubTypeFactory
    {
        public static Dictionary<CloudSubTypes, Func<ICloudSubType>> SpecificCloudSubType = new Dictionary<CloudSubTypes, Func<ICloudSubType>>()
        {
            {CloudSubTypes.Duplicatus,() => new CloudSubType("Duplicatus", "Different Shape", "soething")},
            {CloudSubTypes.Intortus,() =>  new CloudSubType("Duplicatus", "Different Shape", "soething")},
            {CloudSubTypes.Lacunosus,() =>  new CloudSubType("Duplicatus", "Different Shape", "soething")},
            {CloudSubTypes.Opacus,() =>  new CloudSubType("Duplicatus", "Different Shape", "soething")},
            {CloudSubTypes.Perlucidus,() =>  new CloudSubType("Duplicatus", "Different Shape", "soething")},
            {CloudSubTypes.Radiatus,() =>  new CloudSubType("Duplicatus", "Different Shape", "soething")},
            {CloudSubTypes.Translucidus,() =>  new CloudSubType("Duplicatus", "Different Shape", "soething")},
            {CloudSubTypes.Undulatus,() =>  new CloudSubType("Duplicatus", "Different Shape", "soething")},
            {CloudSubTypes.Vertebratus,() =>  new CloudSubType("Duplicatus", "Different Shape", "soething")}
        };
    }
}