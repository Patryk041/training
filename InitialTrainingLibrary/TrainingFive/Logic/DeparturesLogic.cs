using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Toci.TraininigLibrary.Common.Eacrm;
using Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture;

namespace TrainingFive.Logic
{
    public class DeparturesLogic
    {
        public ChmuraDepartureList<DepartureEntity> GetDepartures()
        {
            //tu bedzie pobranie z api

            return new ChmuraDepartureList<DepartureEntity>
            {
                new ChmuraDepartureEntity(1, 2, 1, new DateTime(2012, 2, 2), new DateTime(2012, 4, 4), 1),
                new ChmuraDepartureEntity(1, 2, 1, new DateTime(2012, 4, 5), new DateTime(2012, 7, 7), 1),
            };
        }
    }
}