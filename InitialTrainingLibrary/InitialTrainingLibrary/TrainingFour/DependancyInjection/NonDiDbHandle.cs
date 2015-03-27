using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingFour.DependancyInjection
{
    class NonDiDbHandle
    {
        private DbClient client = new DbClient();
        private DbInsert insert = new DbInsert();


        public int SaveData(DbModel model)
        {
            //insert - render zapytania
            //client - uruchomienie zapytania na bazie danych

            return 1;
        }
    }
}
