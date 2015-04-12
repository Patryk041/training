using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Abstract
{
    public abstract class Phenomenon : IPhenomenon
    {
        public abstract string Name { get; }
        protected abstract string GetDetails();
    }
}