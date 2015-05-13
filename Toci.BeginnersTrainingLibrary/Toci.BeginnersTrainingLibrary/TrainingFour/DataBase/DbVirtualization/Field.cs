using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization
{
    public class Field<T> : IField<T>
    {
        protected string ColumnName;
        protected T FieldValue;
        protected bool FieldIsWhere;
        protected SelectClause Clause;

        public Field(string columnName)
        {
            this.ColumnName = columnName;
        }
        public Field(string columnName, T value)
        {
            this.ColumnName = columnName;
            this.FieldValue = value;
        }
        public Field(string columnName, T value, bool isWhere)
        {
            this.ColumnName = columnName;
            this.FieldValue = value;
            this.FieldIsWhere = isWhere;
        }
        public Field(string columnName, T value, bool isWhere, SelectClause clause)
        {
            this.ColumnName = columnName;
            this.FieldValue = value;
            this.FieldIsWhere = isWhere;
            this.Clause = clause;
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

        public bool IsWhere()
        {
            return FieldIsWhere;
        }

        public void SetWhere(bool isWhere)
        {
            FieldIsWhere = isWhere;
        }

        public void SetSelectClause(SelectClause clause)
        {
            this.Clause = clause;
        }

        public SelectClause GetSelectClause()
        {
            return Clause;
        }
    }
}