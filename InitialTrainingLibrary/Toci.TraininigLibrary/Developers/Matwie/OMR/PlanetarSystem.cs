using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Matwie.OMR
{
    class PlanetarSystem
    {
        private List<AstronimicalObject> _astronimicalObjects = new List<AstronimicalObject>();
        private readonly string _name;

        public PlanetarSystem(string name)
        {
            _name = name;
        }

        private string Name
        {
            get { return _name; }
        }

        public void AddObject(AstronimicalObject asOb)
        {
            _astronimicalObjects.Add(asOb);            
        }
    }

}
