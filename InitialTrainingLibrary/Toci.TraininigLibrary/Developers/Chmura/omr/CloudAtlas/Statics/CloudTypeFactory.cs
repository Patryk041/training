using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class CloudTypeFactory
    {
        public static Dictionary<CloudTypes,CloudType> SpecificCloudTypes = new Dictionary<CloudTypes, CloudType>()
        {
            {CloudTypes.Calvus, new CloudType("Calvus","Shape","Addictional info")}
        };
    }
}