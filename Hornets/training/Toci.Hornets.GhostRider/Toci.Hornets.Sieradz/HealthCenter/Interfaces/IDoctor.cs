using System.Globalization;

namespace Toci.Hornets.Sieradz.HealthCenter.Interfaces
{
    public interface IDoctor : IHuman
    {
        string profession { get; set; }
        Calendar calendar { get; set; }
    }
}