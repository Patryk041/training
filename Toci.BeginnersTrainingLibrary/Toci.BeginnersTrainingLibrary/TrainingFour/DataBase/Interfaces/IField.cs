namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces
{
    public interface IField<T>
    {
        T GetValue();
        string GetColumnName();
        void SetValue(T value);
    }
}