using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization
{
    public class Field<T> : IField<T>
    {
        protected string ColumnName;
        protected T FieldValue;

        public Field(string columnName)
        {
            this.ColumnName = columnName;
        }
        public Field(string columnName, T value)
        {
            this.ColumnName = columnName;
            this.FieldValue = value;
        }

        public T GetValue()
        {
            return FieldValue;
        }

        public string GetColumnName()
        {
            return ColumnName;
        }

        public void SetValue(T value)
        {
            FieldValue = value;
        }

    }
}