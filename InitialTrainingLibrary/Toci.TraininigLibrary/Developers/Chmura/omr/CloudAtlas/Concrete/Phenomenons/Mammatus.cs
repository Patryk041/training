using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Abstract;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete.Phenomenons
{
    public class Mammatus : Phenomenon, ISunShineable
    {
        private string _sunIntensity = "medium";
        public override string Name
        {
            get { return "Mammatus"; }
        }

        protected override string GetDetails()
        {
            return "It is a nice cloud";
        }

        public string SunIntensity
        {
            get { return _sunIntensity; }
            set { _sunIntensity = value; }
        }

        public string PerformSunShine()
        {
            return "I m cool shining";
        }
    }
}