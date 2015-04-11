using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.InteligentBuilding.Abstraction.Buildings
{
    public static class BuildingsNames
    {
        public static readonly string StableName;

        static BuildingsNames()
        {
            //fill static 'consts'
            var culture = CultureInfo.CurrentCulture;

            /// db operations

            StableName = "Stajnia";
        }
    }
}
