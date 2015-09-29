using System.Dynamic;

namespace Toci.Hornets.FactoryTrainings
{
    public interface IBuilding
    {
        string BuildName { get; set; }
        int Area { get; set; }

        bool SecurityProvided();

    }
}