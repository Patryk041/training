using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces
{
    public interface IModel
    {
        string TableName { get;  }
        Dictionary<string, IField<object>> GetDbTableRow();

    }
}