using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.InteligentBuilding.Interfaces.Enums;

namespace Toci.InteligentBuilding.Interfaces.Building
{
    public interface IParcel
    {
        double Surface();

        //List<IBuilding> GetPArceBuildings(); //Dictionary
        Dictionary<IGeographicCoordinates, IBuilding> GetParcelBuildings();

        IGeographicCoordinates GetGeographicCoordinates();
    }
}
