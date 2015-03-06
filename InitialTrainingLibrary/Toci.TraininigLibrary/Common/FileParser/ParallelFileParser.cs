using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Common.FileParser
{
    public class ParallelFileParser<TSaver> where TSaver : IDbSave
    {
        protected Func<FileEntityBase, bool> CustomCallback; 

        //protected List<FileParser<IFileSection, IFileSection, IFileSection>> parsers = new List<FileParser<IFileSection, IFileSection, IFileSection>>();

        public ParallelFileParser(Func<FileEntityBase, bool> customCallback)
        {
            CustomCallback = customCallback;
        }

        public virtual List<Task> ParseFile(FileDetailParserBase fileParser, 
            StreamReader fileReader, int threadsCount)
        {
            List<Task> list = new List<Task>();

            List<string> lines = new List<string>();

            while (!fileReader.EndOfStream)
            {
                lines.Add(fileReader.ReadLine());
            }

            for (int i = 0; i<threadsCount; i++)
            {
                var start = threadsCount*i;
                  // = new Task(ReadSection(fileReader, start, threadsCount));
                list.Add(Task.Factory.StartNew(() => ReadSection(fileParser, lines, start, threadsCount)));
            }

            foreach (var item in list)
            {
                item.Wait();
            }

            return list;
        }


        private void ReadSection(FileDetailParserBase fileParser,
            List<string> lines, int start, int count)
        {


            // wywolac custom callback dla zaczytanego wiersza, dac ifa czy ten callback istnieje

            //logika wyczytujaca z pliku i parsuje
            //for 
            for (int i = start; i < start + count; i++)
            {
                if (i < lines.Count())
                {
                
                    var line = lines[i];

                    FileEntityBase entity = fileParser.ReadEntry(line);
                    if (CustomCallback != null)
                    {
                        CustomCallback(entity);
                    }
                    if (lines.Count() <= start + count*count)
                    {
                        ReadSection(fileParser, lines, start + count*count, count);
                    }
                }
        }

        // start + count * count
            //if
            //ReadSection

        }
    }
}
