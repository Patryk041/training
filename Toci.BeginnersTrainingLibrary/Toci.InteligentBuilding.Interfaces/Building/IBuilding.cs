using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.InteligentBuilding.Interfaces.Enums;

namespace Toci.InteligentBuilding.Interfaces.Building
{
    public interface IBuilding : IVolumeable
    {
        BuildingType GetBuildingType();

        IGeographicCoordinates GetGeographicCoordinates();

        string GetName();
    }
}
