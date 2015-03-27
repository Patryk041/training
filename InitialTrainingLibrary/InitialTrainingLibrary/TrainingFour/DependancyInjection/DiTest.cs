using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Toci.Dal.Models;
using Toci.Db.Clients;
using Toci.Db.ClusterAccess;
using Toci.Db.DbVirtualization.MsSqlQuery;
using Toci.Db.Interfaces;

namespace InitialTrainingLibrary.TrainingFour.DependancyInjection
{
    public class DiTest
    {
        public void test()
        {
            NonDiDbHandle test1 = new NonDiDbHandle();

            DiDbHandle test2 = new DiDbHandle(new DbClient(), new DbInsert());

            //DbHandle handle = new DbHandle(new MsSqlClient("", "", "", ""), new BankAccountTransferModel(), new MsSqlSelect(), );

            var dbHandle = DependancyResolver.Resolve<IDbHandle>();
        }
    }
}
