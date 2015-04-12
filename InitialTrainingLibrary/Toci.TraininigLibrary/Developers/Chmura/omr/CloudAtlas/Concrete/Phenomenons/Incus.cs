using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Abstract;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete.Phenomenons
{
    public class Incus : Phenomenon, IStrormable
    {
        private string _stormIntensity = "strong";

        public override string Name
        {
            get { return "Incus"; }
        }

        protected override string GetDetails()
        {
            return "Strange cloud";
        }

        public string StormIntensity
        {
            get { return _stormIntensity; }
            set { _stormIntensity = value; }
        }

        public string PerformStorm()
        {
            throw new System.NotImplementedException();
        }
    }
}