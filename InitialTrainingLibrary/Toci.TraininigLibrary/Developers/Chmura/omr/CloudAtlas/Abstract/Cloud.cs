using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mono.Math.Prime;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Abstract
{
    public abstract class Cloud : ICloud
    {
        protected IKindOfCloud Kind;
        protected IKindOfCloud MotherKind;
        protected ICloudType CloudType;
        protected ICloudSubType CloudSubType;
        protected List<IPhenomenon> Phenomeons; 
        protected CloudOccurances CloudOccurance;
        protected int HeightInKmAsl;

        public virtual string GetFullName()
        {
            return Kind.Name;
        }
        public abstract CloudHeightTypes GetHeightType();
        public abstract bool HasMother();
       public abstract bool SetType(ICloudType type);
       public abstract bool SetSubType(ICloudSubType subType);
       public abstract bool AddPhenomenon(IPhenomenon phenomenon);


    }
}