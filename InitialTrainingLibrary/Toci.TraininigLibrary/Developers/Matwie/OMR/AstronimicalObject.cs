using System;

namespace Toci.TraininigLibrary.Developers.Matwie.OMR
{
    abstract class AstronimicalObject
    {
        protected static double jakisstalyparametr ;

        static AstronimicalObject()
        {
            jakisstalyparametr = 1.33;

            ///
        }

        protected string Name;
        protected long Mass;
        protected long Age;
        protected long Radius;
        protected double Velocity;
        protected int Angle;
        protected bool Exists;

        protected AstronimicalObject(string name, long mass, long age, long radius, double velocity)
        {
            
            Name = name;
            Mass = mass;
            Age = age;
            Radius = radius;
            Velocity = velocity;
            Exists = true;
        }

        public double GetDensity()
        {
            return Mass / (jakisstalyparametr * Math.PI * Math.Pow(Radius, 3));
        }

        protected void Rotate(int rotationSpeed)
        {
            Angle += rotationSpeed;
        }
    }
}
