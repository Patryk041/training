using Toci.TraininigLibrary.Developers.Mg.Omr.Base;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;
using Toci.TraininigLibrary.Developers.Mg.Omr.Spines;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Mammals
{
    public  class Horse : MammalBase
    {
        public Horse(VertebraeAnimalsNameEnum name, int weight, int height, int age, SexEnum sex) : base(name, weight, height,age, sex)
        {
            this.Spine = new HorseSpine();
        }

      
    }
}
