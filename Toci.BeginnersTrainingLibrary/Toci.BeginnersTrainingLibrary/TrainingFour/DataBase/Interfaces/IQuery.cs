using System.Drawing;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces
{
    public interface IQuery
    {
        string GetQuery(IModel model);
    }
}