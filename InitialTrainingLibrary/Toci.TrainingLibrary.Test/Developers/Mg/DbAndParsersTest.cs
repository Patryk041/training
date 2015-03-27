using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Mg.DB.Clients;
using Toci.TraininigLibrary.Developers.Mg.Polymorphism;
using Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers.Interface;

namespace Toci.TrainingLibrary.Test.Developers.Mg
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string txtPath =
                @"C:\Dropbox\SzkolenieBartekToci\InitialTrainingLibrary\Toci.TraininigLibrary\Developers\Mg\Polymorphism\Parsers\TxtData\transfer_2015_03_12_4343_mg.txt";
            const string xmlPath =
                @"C:\Dropbox\SzkolenieBartekToci\InitialTrainingLibrary\Toci.TraininigLibrary\Developers\Mg\Polymorphism\Parsers\XmlData\transfer_2015_03_12_4343_mg.xml";
            IMgTransferParser txtParser = new MgParsersFactory().GetProperParser(txtPath);
            IMgTransferParser xmlParser = new MgParsersFactory().GetProperParser(xmlPath);

            var txtResult = txtParser.GetEntityTransfersList(txtPath);
            var xmlResult = xmlParser.GetEntityTransfersList(xmlPath);

            MgPostgreClient postgreClient = new MgPostgreClient("postgres","qwerty","toci","127.0.0.1");
            postgreClient.SetData("insert into MgTable values (1,'Mg','Kowalsky');");

            var resultDataSet = postgreClient.GetData("select * from MgTable");

        }
    }
}
