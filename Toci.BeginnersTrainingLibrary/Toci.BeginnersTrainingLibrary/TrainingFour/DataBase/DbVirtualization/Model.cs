using System.Collections.Generic;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization
{
    public abstract class Model : IModel
    {
        public const string ID = "id";

        protected Dictionary<string, IField<object>> DbTableRow = new Dictionary<string, IField<object>>();
        public string TableName { get; protected set; }

        protected Model(string tableName)
        {
            this.TableName = tableName;
        }

        public Dictionary<string, IField<object>> GetDbTableRow()
        {
            return DbTableRow;
        }

        public int Id
        {
            get
            {
                return (int)DbTableRow[ID].GetValue();
            }
            set
            {
                SetValue(ID, value);
            }
        }

        protected void SetValue<T>(string key, T value)
        {
            if (DbTableRow.ContainsKey(key))
            {
                DbTableRow[key].SetValue(value);
            }
            else
            {
                DbTableRow.Add(key, new Field<object>(key, value));
            }
        }
    }
}