namespace Anathema.wojtek.factory
{
    public interface IBike
    {
        string Colour { get; set; }
        int FrameSize { get; set; }
        int WheelSize { get; set; }
        string Destination { get; set; }

        bool Ride(string destination);
        
    }
}
