using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class CloudSubTypeFactory
    {
        public static Dictionary<CloudSubTypes, CloudSubType> SpecificCloudSubType = new Dictionary<CloudSubTypes, CloudSubType>()
        {
            {CloudSubTypes.Duplicatus, new CloudSubType("Duplicatus", "Different Shape", "soething")}
        };
    }
}