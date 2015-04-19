using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DAL;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization.Clients;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization.Queries;

namespace Toci.BeginnersTest.TrainingFour.DB
{
    [TestClass]
    public class DbTests
    {
        [TestMethod]
        public void TestInsert()
        {
            CarModel myModel = new CarModel("car"){Id = 1, Nazwa = "Ferrari"};
            PostgresqlInsert insert = new PostgresqlInsert();
            var zmienna = insert.GetQuery(myModel);
            
        }

        [TestMethod]
        public void TestPostgreClient()
        {
            //PostgresqlCient client = new PostgresqlCient("postgres","beatka","localhost","postgres");
            //client.Save();

            Handle myHandle = new Handle(new PostgresqlCient("postgres", "beatka", "localhost", "postgres"),new PostgresqlInsert(), new PostgresqlInsert(), new PostgresqlInsert(), new PostgresqlInsert());
            myHandle.Insert(new CarModel("car") {Id = 1, Nazwa = "Ferrari"});
        }
    }
}