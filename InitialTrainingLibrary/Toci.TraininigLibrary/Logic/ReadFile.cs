using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Logic
{
    public class ReadFile
    {
        private readonly ParsersFactory _factory = new ParsersFactory();

        public void Execute ()
        {
            
            string[] filePaths = DirectoryFileList.GetPathList();

            filePaths.AsParallel().WithDegreeOfParallelism(5).ForAll(ParallelFileParse);
        }


        private void ParallelFileParse(string filePath)
        {

         // FileDetailParserBase parser = new ParsersFactory().GetProperParser(DirectoryFileList.GetParserName(filePath).ToUpper());

            FileDetailParserBase parser = _factory.GetProperParser(DirectoryFileList.GetParserName(filePath).ToUpper());

            ParallelFileParser<IDbSave> fileParser = new ParallelFileParser<IDbSave>(null);

            fileParser.ParseFile(parser, new StreamReader(filePath), 10);
        }
    }
}
