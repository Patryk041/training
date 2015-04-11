namespace Toci.TraininigLibrary.Developers.Matwie.OMR
{
    class Star : AstronimicalObject
    {
        private int _temperature;

        public Star(string name, long mass, long age, long radius, double velocity, int temperature) : base(name, mass, age, radius, velocity)
        {
            _temperature = temperature;
        }

        public int Temperature
        {
            get { return _temperature; }
        }
    }
}
