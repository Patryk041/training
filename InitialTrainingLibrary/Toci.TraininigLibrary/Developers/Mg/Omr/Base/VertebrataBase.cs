using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;
using Toci.TraininigLibrary.Developers.Mg.Omr.Interfaces;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Base
{
    public abstract class VertebrataBase : IVertebrae
    {

        protected VertebrataBase(VertebraeAnimalsNameEnum name, int weight, int height,int age,SexEnum sex)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Sex = sex;
            Age = age;
        }

        public VertebraeAnimalsNameEnum Name { get; protected set; }
        public SpineBase Spine { get; protected set; }
     
        public int Weight {get; protected set; }
        public int Height {get; protected set; }
        public int Age {get; protected set; }
        public SexEnum Sex { get; protected set; }

        public float AmountOfBlood { get; protected set; }
        public MultiplicationEnum MultiplicationType { get; protected set; }
        public BodyTemperatureEnum BodyTemperatureType { get; protected set; }
        


        public virtual void Move()
        {
            throw new NotImplementedException();
        }

        public virtual void Eat()
        {
            throw new NotImplementedException();
        }

        public virtual void Sleep()
        {
            throw new NotImplementedException();
        }

        public virtual void Breath()
        {
            throw new NotImplementedException();
        }

        public virtual void Reproduce()
        {
            throw new NotImplementedException();
        }

        public virtual string MakeNoise()
        {
            throw new NotImplementedException();
        }
    }
}
