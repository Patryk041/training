using System.Xml.Linq;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces
{
    public interface IClient
    {
        int Save(string query);
    }
}