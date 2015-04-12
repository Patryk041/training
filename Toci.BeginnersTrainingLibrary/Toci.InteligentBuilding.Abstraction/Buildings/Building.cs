using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.InteligentBuilding.Interfaces;
using Toci.InteligentBuilding.Interfaces.Building;
using Toci.InteligentBuilding.Interfaces.Enums;

namespace Toci.InteligentBuilding.Abstraction.Buildings
{
    public abstract class Building : IBuilding
    {
        protected BuildingType BuildingType; //filled in derived type constructor

        public double Height { get; set; }

        public double Width { get; set; }

        public double Length { get; set; }

        public double GetVolume()
        {
            return Height * Width * Length;
        }

        public double GetSurface()
        {
            return Length*Width;
        }

        public BuildingType GetBuildingType()
        {
            return BuildingType;
        }

        public IGeographicCoordinates GetGeographicCoordinates()
        {
            throw new NotImplementedException();
        }

        public abstract string GetName();
    }
}
