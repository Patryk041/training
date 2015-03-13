using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.DbVirtualization
{
    public abstract class Model : IModel
    {
        public const string ID = "id";
        protected Dictionary<string, IDbField<object>> Fields = new Dictionary<string, IDbField<object>>();
        protected string TableName;

        protected Model(string tableName)
        {
            this.TableName = tableName;
        }
        public Dictionary<string, IDbField<object>> GetFields()
        {
            return Fields;
        }

        public IDbField<object> GetField(string columnName)
        {
            return Fields.ContainsKey(columnName) ? Fields[columnName] : null;
        }

        public string GetTableName()
        {
            return TableName;
        }

        public int Id
        {
            get
            {
                return (int) Fields[ID].GetValue();
            }
            set
            {
                SetValue(ID, value);
            }
        }

        protected void SetValue<T>(string key, T value)
        {
            if (Fields.ContainsKey(key))
            {
                Fields[key].SetValue(value);
            }
            else
            {
                Fields.Add(key, new DbField<object>(key, value));
            }
        }
    }
}
