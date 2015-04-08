namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface
{
    public interface ICloudType
    {
        string Name { get; }
        string Shape { get; }
        string GetCharacteristic();
    }
}