using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Db.Interfaces;

namespace Toci.Db.ClusterAccess
{
    public class DbHandle : IDbHandle
    {
        protected IDbClient client;
        protected IModel model;
        protected IQuery select;
        protected IQuery insert;
        protected IQuery update;
        protected IQuery delete;

        public DbHandle(IDbClient client, IModel model, IQuery select, IQuery insert, IQuery update, IQuery delete)
        {
            this.client = client;
            this.model = model;
            this.select = select;
            this.update = update;
            this.delete = delete;
            this.insert = insert;
        }
        public DataSet GetData()
        {
            throw new NotImplementedException();
        }

        public int InsertData()
        {
            return client.SetData(insert.GetQuery(model));
        }

        public int UpdateData()
        {
            throw new NotImplementedException();
        }

        public int DeleteData()
        {
            throw new NotImplementedException();
        }
    }
}
