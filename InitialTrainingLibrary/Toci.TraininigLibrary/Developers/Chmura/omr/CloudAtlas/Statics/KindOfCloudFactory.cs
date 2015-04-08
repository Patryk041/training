using System;
using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Statics;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class KindOfCloudFactory
    {
        public static Dictionary<KindsOfCloud, Func<IKindOfCloud>> SpecificKindsOfClouds = new Dictionary<KindsOfCloud, Func<IKindOfCloud>>()
        {
           {KindsOfCloud.Altocumulus, () => new KindOfCloud("Altocumulus","medium clouds","Small round", new List<ICloudType>()
                {
                    CloudTypeFactory.SpecificCloudTypes[CloudTypes.Stratiformis].Invoke(), CloudTypeFactory.SpecificCloudTypes[CloudTypes.Lenticularis].Invoke(),
                    CloudTypeFactory.SpecificCloudTypes[CloudTypes.Castellanus].Invoke(),CloudTypeFactory.SpecificCloudTypes[CloudTypes.Floccus].Invoke()
                }, new List<ICloudSubType>()
                {
                    CloudSubTypeFactory.SpecificCloudSubType[CloudSubTypes.Translucidus].Invoke(),CloudSubTypeFactory.SpecificCloudSubType[CloudSubTypes.Perlucidus].Invoke(),
                    CloudSubTypeFactory.SpecificCloudSubType[CloudSubTypes.Opacus].Invoke(),CloudSubTypeFactory.SpecificCloudSubType[CloudSubTypes.Duplicatus].Invoke(),
                    CloudSubTypeFactory.SpecificCloudSubType[CloudSubTypes.Undulatus].Invoke(),CloudSubTypeFactory.SpecificCloudSubType[CloudSubTypes.Radiatus].Invoke(),
                    CloudSubTypeFactory.SpecificCloudSubType[CloudSubTypes.Lacunosus].Invoke()
                }, new List<IPhenomenon>()
                {
                    PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Virga].Invoke(),PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Mammatus].Invoke()
                })},

            {KindsOfCloud.Cumulus,() => new KindOfCloud("Cumulus","White, made of water","Small regular", new List<ICloudType>()
                {
                    CloudTypeFactory.SpecificCloudTypes[CloudTypes.Humilis].Invoke(),CloudTypeFactory.SpecificCloudTypes[CloudTypes.Mediocris].Invoke(),
                    CloudTypeFactory.SpecificCloudTypes[CloudTypes.Congestus].Invoke(),CloudTypeFactory.SpecificCloudTypes[CloudTypes.Fractus].Invoke()
                }, new List<ICloudSubType>()
                {
                    CloudSubTypeFactory.SpecificCloudSubType[CloudSubTypes.Radiatus].Invoke()
                }, new List<IPhenomenon>()
                {
                    PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Pileus].Invoke(),PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Velum].Invoke(),
                    PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Praecipitatio].Invoke(),PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Virga].Invoke(),
                    PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Arcus].Invoke(),PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Pannus].Invoke(),
                    PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Tuba].Invoke()
                })},
             {KindsOfCloud.Nimbostratus,() => new KindOfCloud("Nimbostratus","Gray, made of water, bad one","Big smooth", new List<ICloudType>()
                {
                }, new List<ICloudSubType>()
                {
                }, new List<IPhenomenon>()
                {
                    PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Praecipitatio].Invoke(),PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Pannus].Invoke(),
                    PhenomenonFactory.SpecificPhenomenon[PhenomenonKinds.Virga].Invoke()
                })},
                {KindsOfCloud.Stratus, () => new KindOfCloud()}

        };
    }
}