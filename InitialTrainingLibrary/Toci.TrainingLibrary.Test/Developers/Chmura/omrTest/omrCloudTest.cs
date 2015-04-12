using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Statics;

namespace Toci.TrainingLibrary.Test.Developers.Chmura.omrTest
{
    [TestClass]
    public class omrCloudTest
    {
        [TestMethod]
        public void CloudTest()
        {
            var kind1 = KindOfCloudFactory.SpecificKindsOfClouds[KindsOfCloud.Stratus];
            var cloud1 = new ParticularCloud(KindOfCloudFactory.SpecificKindsOfClouds[KindsOfCloud.Cumulus],
                CloudOccurances.Moderate, 5);
            cloud1.SetType(CloudTypeFactory.SpecificCloudTypes[CloudTypes.Humilis].Invoke());
            cloud1.SetSubType(CloudSubTypeFactory.SpecificCloudSubType[CloudSubTypes.Radiatus].Invoke());
            cloud1.AddPhenomenon(PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Arcus].Invoke());

            //var b = cloud1.CanStorm();
        }
    }
}