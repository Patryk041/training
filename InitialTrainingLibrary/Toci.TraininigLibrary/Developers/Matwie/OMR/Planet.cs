using Toci.TraininigLibrary.Developers.Matwie.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Matwie.OMR
{
    class Planet : AstronimicalObject, IDestroyable
    {
        private bool _inhabited;

        public Planet(string name, long mass, long age, long radius, double velocity, bool inhabited) : base(name, mass, age, radius, velocity)
        {
            _inhabited = inhabited;
        }

        public void Destroy()
        {
            _inhabited = false;
            Exists = false;
        }

        public bool Inhabited 
        {
            get { return _inhabited; }
        }
    }
}
