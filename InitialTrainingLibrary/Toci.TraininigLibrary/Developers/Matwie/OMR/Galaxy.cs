using System;
using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Matwie.OMR
{
    class Galaxy
    {
        public List<PlanetarSystem> PlanetarSystems = new List<PlanetarSystem>();
        readonly Random _rand = new Random();

        public void AddPlanetarSystems(PlanetarSystem planetarSystem)
        {
            PlanetarSystems.Add(planetarSystem);
        }

        public Galaxy()
        {
            foreach (var planetarSystem in PlanetarSystems)
            {
                planetarSystem.AddObject(new Star("Sun", _rand.Next(), _rand.Next(), _rand.Next(), _rand.Next(), _rand.Next()));
                for(int i = _rand.Next(0, 100); i < 110; i++)
                    planetarSystem.AddObject(new Planet("dasda", _rand.Next(), _rand.Next(), _rand.Next(), _rand.Next(), _rand.Next() % 2 == 0));
                for (int i = _rand.Next(0, 50); i < 50; i++)
                    planetarSystem.AddObject((new Asteroid("asd", _rand.Next(), _rand.Next(), _rand.Next(), _rand.Next())));
            }
        }
    }
}
