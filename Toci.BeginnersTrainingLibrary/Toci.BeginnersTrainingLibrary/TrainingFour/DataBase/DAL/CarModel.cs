using System.ComponentModel;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DAL
{
    public class CarModel : Model
    {
        public const string NAZWA = "nazwa";

        public CarModel(string tableName) : base(tableName)
        {
        }

        public string Nazwa
        {
            get
            {
                return (string)DbTableRow[NAZWA].GetValue();
            }
            set
            {
                SetValue(NAZWA, value);
            }
        }
    }
}