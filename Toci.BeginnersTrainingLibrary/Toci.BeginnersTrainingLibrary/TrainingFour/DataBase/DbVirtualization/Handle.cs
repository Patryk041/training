using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization
{
    public class Handle : IHandle
    {
        protected IClient client;
        protected IQuery insert;

        public Handle(IClient client, IQuery select, IQuery insert, IQuery update, IQuery delete)
        {
            this.client = client;
            this.insert = insert;
        }

        public int Insert(IModel model)
        {
            return client.Save(insert.GetQuery(model));
        }
    }
}