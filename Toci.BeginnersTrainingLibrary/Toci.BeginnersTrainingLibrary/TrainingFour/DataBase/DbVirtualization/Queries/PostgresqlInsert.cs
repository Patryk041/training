using System.Linq;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization.Queries
{
    public class PostgresqlInsert : IInsert
    {
        private const string INSERTpattern = "Insert into {0} ({1}) values ({2});"; // insert into samochod (id, nazwa) values (2, 'ferrari');
        public string GetQuery(IModel model)
        {
            string columns = string.Join(" , ", model.GetDbTableRow().Select(x => x.Key)); // Id , Nazwa
            string values = string.Join(" , ", model.GetDbTableRow().Select(x => string.Format("'{0}'", x.Value.GetValue())));

            return string.Format(INSERTpattern, model.TableName, columns, values);
        }
    }
}