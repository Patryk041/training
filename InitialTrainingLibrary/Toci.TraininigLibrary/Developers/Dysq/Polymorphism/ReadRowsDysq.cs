using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Dysq.XML;

namespace Toci.TraininigLibrary.Developers.Dysq.Polymorphism
{
    public class ReadRowsDysq 
    {
        public static DysqFileEntityPolymorphism ReadRows(string path)
        {
            DysqFileEntityPolymorphism dysqEntities = new DysqFileEntityPolymorphism();

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    //var fieldsAfterSplit = splitItDysq(line);

                    dysqEntities = (SplitItDysq(line));
                    
                }
            }

            return dysqEntities;
        }

       
        public static DysqFileEntityPolymorphism SplitItDysq(string line)
        {
             const char delimiter = '-';
             DysqFileEntityPolymorphism entity = new DysqFileEntityPolymorphism();

            var fields = line.Split(delimiter);

            entity.Bank = fields[0];
            entity.Name = fields[1];
            entity.Surname = fields[2];
            entity.SourceAccount = fields[3];
            entity.DateOfTransaction = Convert.ToDateTime(fields[4]).ToString();
            entity.Amount = fields[5];

            return entity;


        }
    }
}
