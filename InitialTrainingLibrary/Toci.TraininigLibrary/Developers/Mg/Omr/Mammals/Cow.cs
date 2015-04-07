using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base;
using Toci.TraininigLibrary.Developers.Mg.Omr.Enums;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;
using Toci.TraininigLibrary.Developers.Mg.Omr.Spines;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Mammals
{
    public class Cow : MammalBase
    {
       
       private const float AverageCowBloodPercentage = 0.08f;

       public Cow(int weight, int height, int age):base(VertebraeAnimalsNameEnum.Cow,  weight,  height,age,SexEnum.Female)
       {
           this.AmountOfBlood = AverageCowBloodPercentage * weight;
           this.Spine = new CowSpine();
       }

       public override string MakeNoise()
       {
           return "Moooo";
       }

        public virtual int GiveMilk()
        {
            return new Random().Next(0, 5); //amount
        }

       
        
    }
}
