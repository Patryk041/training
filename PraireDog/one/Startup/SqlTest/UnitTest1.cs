using System;
using Cassandra;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SqlTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestMethod]
        public void TestSqlCassandra()
        {
           Cluster cluster;
           cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
           ISession isession = cluster.Connect();
            isession.Execute("Insert into \"Cassandra\".\"Kasandra\"(id_prawidlowe, \"name\") Values(50, \'aaaa\')");
        }
    }
}
