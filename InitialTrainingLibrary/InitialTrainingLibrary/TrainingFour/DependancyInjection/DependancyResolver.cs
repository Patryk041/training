using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Toci.Dal.Models;
using Toci.Db.Clients;
using Toci.Db.ClusterAccess;
using Toci.Db.DbVirtualization.MsSqlQuery;
using Toci.Db.Interfaces;

namespace InitialTrainingLibrary.TrainingFour.DependancyInjection
{
    class DependancyResolver
    {
        public static T Resolve<T>()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MsSqlInsert>().As<IQuery>();
            builder.RegisterType<BankAccountTransferModel>().As<IModel>();
            builder.RegisterType<PostgreSqlClient>().As<IDbClient>().
                WithParameters(new Parameter[] { new NamedParameter("name", ""), new NamedParameter("password", ""), new NamedParameter("dbAddress", ""), new NamedParameter("dbName", "beatka") });
            builder.RegisterType<DbHandle>().As<IDbHandle>();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<T>();

                return service;
            }
        }


    }
}
