using System.Collections.Generic;

namespace Toci.Hornets.FactoryTrainings
{
    public class BuildingFactory
    {
        private List<Building> buildingsList;

        BuildingFactory()
        {
            buildingsList = new List<Building>()
            {
                { new BusStation()},
                { new Cinema() },
                { new School()}
            };
        }
    }
}