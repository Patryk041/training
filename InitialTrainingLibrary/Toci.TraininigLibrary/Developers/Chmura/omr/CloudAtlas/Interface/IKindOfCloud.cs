using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface
{
    public interface IKindOfCloud
    {
        string Name { get; }
        string Details { get; }
        string BaseShape { get; }
        string AdditionalCharacteristics { get; set; }
        List<ICloudType> GetMathedCloudTypes();
        List<ICloudSubType> GetMathedCloudSubTypes();
        List<IPhenomenon> GetMathedPhenomeons();

    }
}