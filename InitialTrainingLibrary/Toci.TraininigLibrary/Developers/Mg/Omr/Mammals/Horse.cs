using Toci.TraininigLibrary.Developers.Mg.Omr.Base;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.Skeleton.Spines;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Mammals
{
    public  class Horse : MammalBase
    {
        public Horse(VertebrataAnimalsNameEnum name, int weight, int height, int age, SexEnum sex) : base(name, weight, height,age, sex)
        {
            this.Spine = new HorseSpine();
        }

      
    }
}
