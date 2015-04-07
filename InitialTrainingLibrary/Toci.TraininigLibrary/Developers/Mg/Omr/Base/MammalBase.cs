using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Mg.Omr.Enums;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;
using Toci.TraininigLibrary.Developers.Mg.Omr.Spines;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Base
{
    public abstract class MammalBase : VertebrataBase
    {
        protected MammalBase(VertebraeAnimalsNameEnum name, int weight, int height, int age,SexEnum sex): base(name, weight,height,age,sex)
        {

            this.BodyTemperatureType = BodyTemperatureEnum.WarmBlooded;

            this.MultiplicationType = (name == VertebraeAnimalsNameEnum.Platypus ||
                                       name == VertebraeAnimalsNameEnum.Echidna)
                ? MultiplicationEnum.Viviparity
                : MultiplicationEnum.Oviparity;

           
        }


    }
}
