namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface
{
    public interface IFallable
    {
        string FallsIntensity { get; set; }
        string TypeOfFalls { get; set; }
        string PerformFalling(); 
    }
}