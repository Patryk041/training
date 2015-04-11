using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Mammals
{
    public class Cow : MammalBase
    {
       
       private const float AverageCowBloodPercentage = 0.08f;

       public Cow(int weight, int height, int age):base(VertebrataAnimalsNameEnum.Cow,  weight,  height,age,SexEnum.Female)
       {
           CirculatorySystem.AmountOfBlood = AverageCowBloodPercentage * weight;


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
