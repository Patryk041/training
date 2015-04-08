
using System;
using System.Linq;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Abstract;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Statics;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class ParticularCloud : Cloud
    {
        public ParticularCloud(Func<IKindOfCloud> kind, CloudOccurances occurance, int height)
        {
            this.Kind = kind.Invoke();
            this.CloudOccurance = occurance;
            this.HeightInKmAsl = height;
        }
        public ParticularCloud(KindOfCloud kind, CloudOccurances occurance, int height, KindOfCloud mother)
        {
            this.Kind = kind;
            this.CloudOccurance = occurance;
            this.HeightInKmAsl = height;
            this.MotherKind = mother;
        }

        public IKindOfCloud GetKind()
        {
            return this.Kind;
        }
        public override string GetFullName()
        {
            return Kind.Name + " " + CloudType.Name + " " + CloudSubType.Name;
        }
        public override CloudHeightTypes GetHeightType()
        {
            return CloudAtlasHelpers.ComputeHeightType(this.HeightInKmAsl, CloudOccurance);
        }

        public override bool HasMother()
        {
            return MotherKind != null;
        }

        public override bool SetType(ICloudType type)
        {
            if (Kind.GetMathedCloudTypes().Contains(type))
            {
                CloudType = type;
                return true;
            }
            return false;
        }

        public override bool SetSubType(ICloudSubType subType)
        {
            if (Kind.GetMathedCloudSubTypes().Contains(subType))
            {
                CloudSubType = subType;
                return true;
            }
            return false;
        }

        public override bool AddPhenomenon(IPhenomenon phenomenon)
        {
            if (Kind.GetMathedPhenomeons().Contains(phenomenon))
            {
                Phenomeons.Add(phenomenon);
                return true;
            }
            return false;
        }

        public bool CanStorm()
        {
            return Phenomeons.Any(item => item.GetType() == typeof(IStrormable));
        }
    }
}