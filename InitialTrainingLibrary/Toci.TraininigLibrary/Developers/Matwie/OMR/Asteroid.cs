using Toci.TraininigLibrary.Developers.Matwie.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Matwie.OMR
{
    class Asteroid : AstronimicalObject, IDestroyable
    {
        public Asteroid(string name, long mass, long age, long radius, double velocity)
            : base(name, mass, age, radius, velocity)
        {

        }

        public void Destroy()
        {
            Exists = false;
        }
    }
}
