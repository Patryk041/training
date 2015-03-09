using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Test.koziu;
using System.Collections.Generic;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Domi;
using Toci.TraininigLibrary.Developers.Dysq.FileParser;
using Toci.TraininigLibrary.Developers.Koziu.FileParser;
using Toci.TraininigLibrary.Developers.RS.FileParser;

namespace Toci.TrainingLibrary.Test.Developers.Koziu
{
    [TestClass]
    public class KoziuFileGeneratorTest
    {
        [TestMethod]
        public void FileGeneratorTest()
        {
            FileGenerator generator = new FileGenerator();
            Dictionary<string, List<FileEntityBase>> content = new Dictionary<string, List<FileEntityBase>>();
            DysqFileEntity a = new DysqFileEntity();
            DysqFileEntity b = new DysqFileEntity();
            DomiFileEntity c = new DomiFileEntity();
            RsFileEntity d = new RsFileEntity();
            KoziuFileEntity e = new KoziuFileEntity();

            a.SetName("Dysq");
            a.SetSurname("Raz");
            a.SetDate(DateTime.Today.ToShortDateString());
            a.SetAccount("1234561234");

            b.SetName("Dysq");
            b.SetSurname("Dwa");
            b.SetDate(DateTime.Today.ToShortDateString());
            b.SetAccount("1234561234");

            c.GetName("Domi");
            c.GetSurname("Raz");
            c.GetDate(DateTime.Today.ToShortDateString());
            c.GetAccount("1234561234");

            d.SetName("RS");
            d.SetSurname("Raz");
            d.SetDate(DateTime.Today.ToShortDateString());
            d.SetAccount("1234561234");

            e.SetName("Koziu");
            e.SetSurname("Raz");
            e.SetDate(DateTime.Today);
            e.SetAccount("1234561234");
            



            List<FileEntityBase> fileEntity = new List<FileEntityBase>();
            fileEntity.Add(a);
            fileEntity.Add(b);    
            fileEntity.Add(c);  
            fileEntity.Add(d);
            fileEntity.Add(e);
            content.Add("Koziu", fileEntity);
            generator.Generate(content);
        
        }
    }
}
