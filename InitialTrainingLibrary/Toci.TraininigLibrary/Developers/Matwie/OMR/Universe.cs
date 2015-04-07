using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Matwie.OMR
{
    class Universe
    {
        private List<Galaxy> _galaxies = new List<Galaxy>();

        public Universe()
        {
            for (int i = 0; i > 1000; i++) 
                _galaxies.Add(new Galaxy());
        }
    }
}
