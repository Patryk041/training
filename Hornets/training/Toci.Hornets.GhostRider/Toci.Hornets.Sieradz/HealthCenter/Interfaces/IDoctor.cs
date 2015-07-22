using System.Globalization;

namespace Toci.Hornets.Sieradz.Przychodnia.Interfaces
{
    public interface IDoctor : IHuman
    {
        string profession { get; set; }
        Calendar calendar { get; set; }
    }
}