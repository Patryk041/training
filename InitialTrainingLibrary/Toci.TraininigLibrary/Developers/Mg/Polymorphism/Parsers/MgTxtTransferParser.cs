using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers.Interface;


namespace Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers
{
    public class MgTxtTransferParser : IMgTransferParser
    {
        public List<FileEntityBase> GetEntityTransfersList(string filePath)
        {
            const string supportedExtension = "TXT";
            if (filePath.Substring(filePath.Length - 3, 3).ToUpper() != supportedExtension) throw new ArgumentException("PLIK NIE JEST PLIKIEM TEKSTOWYM");

            return ReadFileLines(filePath).ToList();
        }

        private IEnumerable<FileEntityBase> ReadFileLines(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    yield return SplitRow(reader.ReadLine());
                }
            }
        }

        private FileEntityBase SplitRow(string row)
        {

            const char rowDelimiter = '/';
            const char dateDelimiter = '_';
            var entityRows = row.Split(rowDelimiter);
            if (entityRows.Length != 4) return null;
            var date = entityRows[2].Split(dateDelimiter);

            //Michał/Garbacz/2015_03_06/1353403124232932323


            return new FileEntityBase()
            {
                Name = entityRows[0],
                Surname = entityRows[1],
                Date = new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2])),
                Account = entityRows[3]

            };
        }
    }
}
