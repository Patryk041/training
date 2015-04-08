using System.Runtime.CompilerServices;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Abstract;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete.Phenomenons
{
    public class Arcus : Phenomenon, IStrormable, IFallable, IWindable
    {

        private string _stormIntensity = "strong";
        private string _fallsIntensity = "strong";
        private string _windIntensity = "medium";
        private string _typeOfFalls = "rain";
        public override string Name
        {
            get { return "Arcus"; }
        }

        protected override string GetDetails()
        {
            return "Bad cloud";
        }

        public string StormIntensity
        {
            get { return _stormIntensity; }
            set { _stormIntensity = value; }
        }

        public string PerformStorm()
        {
            return "Bang!";
        }

        public string FallsIntensity
        {
            get { return _fallsIntensity; }
            set { _fallsIntensity = value; }
        }

        public string TypeOfFalls
        {
            get { return _typeOfFalls; }
            set { _typeOfFalls = value; }
        }

        public string PerformFalling()
        {
            return "falll";
        }

        public string WindIntensity
        {
            get { return _windIntensity; }
            set { _windIntensity = value; }
        }

        public string PerformWind()
        {
            return "wiiinddyyy";
        }
    }
}