using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces
{
    public interface IField<T>
    {
        T GetValue();
        string GetColumnName();
        void SetValue(T value);
        bool IsWhere();
        SelectClause GetSelectClause();
        void SetWhere(bool isWhere);
        void SetSelectClause(SelectClause clause);
    }
}