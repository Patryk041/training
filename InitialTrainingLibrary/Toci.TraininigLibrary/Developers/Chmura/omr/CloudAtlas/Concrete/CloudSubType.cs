using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class CloudSubType : CloudType, ICloudSubType
    {
        public CloudSubType( string name, string shape, string details) : base(name, shape, details)
        {
        }
    }
}