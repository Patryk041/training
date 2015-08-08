using System;
using System.Collections.Generic;
using System.Linq;
namespace Toci.Hornets.GhostRider.TrainingSix.Database.Abstraction.Model
{
    public abstract class DataStorageQuery // data storage mysql postgresql vs mongo db tyrant 
    {
        private const string DatabaseValueFormatPattern = "{0}{1}{0}";

        private const string CommandColumnsDelimiter = ", ";

        protected Dictionary<Type, string> Surroundings = new Dictionary<Type, string>
        {
            { typeof(int), "" },
            { typeof(string), "'" },
        };
         //uruchomienie zapytan na silniku skladowania danych

        public abstract string GetSetDataCommand(StorageDataModel<object> model); // insert  update  delete        SET table serizlaizwaoana siecka

        protected virtual string GetColumnsDelimitedList(StorageDataModel<object> model)
        {
            return string.Join(CommandColumnsDelimiter, model.Data.Select(item => item.Key).ToArray());
        }

        protected virtual string FormatDatabaseValue<T>(T value) // 'dsfafasd'  2
        {
            return string.Format(DatabaseValueFormatPattern, Surroundings.ContainsKey(typeof(T)) ? Surroundings[typeof(T)] : "'", value);
        }
    }
}