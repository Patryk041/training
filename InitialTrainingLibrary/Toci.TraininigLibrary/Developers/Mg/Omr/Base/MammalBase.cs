
using Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.BodyCover;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.CirculatorySystem;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.DigestiveSystem;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.NervousSystem;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.RespiratorySystem;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.Skeleton;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;


namespace Toci.TraininigLibrary.Developers.Mg.Omr.Base
{
    public abstract class MammalBase : VertebrataBase
    {
        protected MammalBase(VertebrataAnimalsNameEnum name, int weight, int height, int age,SexEnum sex): base(name, weight,height,age,sex)
        {

            this.BodyTemperatureType = BodyTemperatureEnum.WarmBlooded;

            this.MultiplicationType = (name == VertebrataAnimalsNameEnum.Platypus ||
                                       name == VertebrataAnimalsNameEnum.Echidna)
                ? MultiplicationEnum.Viviparity
                : MultiplicationEnum.Oviparity;

            this.BodyCover = new MammalBodyCover();
            this.CirculatorySystem = new MammalCirculatorySystem();
            this.DigestiveSystem = new MammalDigestiveSystem();
            this.NervousSystem = new MammalNervousystem();
            this.RespiratorySystem = new MammalRespiratoryeSystem();
            this.Skeleton = new MammalSkeleton(SpineHelperFactory.GetProperSpine[name]());
            
           
        }


    }
}
