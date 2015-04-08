using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class KindOfCloudFactory
    {
        public static Dictionary<KindsOfCloud, KindOfCloud> SpecificKindsOfClouds = new Dictionary<KindsOfCloud, KindOfCloud>()
        {
            {KindsOfCloud.Altocumulus, new KindOfCloud("Altocumulus","","", new List<ICloudType>()
            {
                
            }, new List<ICloudSubType>()
            {
                
            }, new List<IPhenomenon>()
            {
                
            })}
        };
    }
}