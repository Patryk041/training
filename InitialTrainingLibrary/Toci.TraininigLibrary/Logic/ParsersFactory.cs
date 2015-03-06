using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;
using Toci.TraininigLibrary.Developers.Domi;
using Toci.TraininigLibrary.Developers.Dysq.FileParser;
using Toci.TraininigLibrary.Developers.Hipek.FileParser;
using Toci.TraininigLibrary.Developers.Koziu.FileParser;
using Toci.TraininigLibrary.Developers.Mg;
using Toci.TraininigLibrary.Developers.RS.FileParser;
using Toci.TraininigLibrary.Developers.Santi.FileParser;
using Toci.TraininigLibrary.Developers.Warrior.FileParser;

namespace Toci.TraininigLibrary.Logic
{
    public class ParsersFactory
    {
        /// <summary>
        /// Zwraca listę obiektów typu EntityBase (pojedyńczy rekord). Argument = string [] directotryPaths
        /// </summary>
        /// <param name="path"></param>
        public void GetData()
        {
            string[] filePaths = DirectoryFileList.GetPathList();

            filePaths.AsParallel().WithDegreeOfParallelism(5).ForAll(ParallelFileParse);
        //temp.AsParallel().WithDegreeOfParallelism(5).ForAll(i => entityBaseList.Add(GetProperParser(i.GetName()).ReadEntry("Dominika;Dziurzynska;2015-03-13;13039302007")));
        }

        protected void ParallelFileParse(string filePath)
        {
            FileDetailParserBase parser = GetProperParser(DirectoryFileList.GetParserName(filePath).ToUpper());

            ParallelFileParser<IDbSave> fileParser = new ParallelFileParser<IDbSave>(null);

            fileParser.ParseFile(parser, new StreamReader(filePath), 10);
        }

        private FileDetailParserBase GetProperParser(string name)
        {
            Dictionary<string, Func<FileDetailParserBase>> parserFactory = new Dictionary<string, Func<FileDetailParserBase>>()
            {
              //  {"mg",(_path) => new MgFileParser().GetParser(path)}
              //  { "Domi", () => { return (FileParser<FileHeaderParserBase, FileDetailParserBase, FileFooterParserBase>)new DomiFileParser(); } }
                { "DOMI", () => new DomiFileDetails()},
                { "SANTI", () => new SantiFileDetailParser()},
                { "RS", () => new RsFileDetailsParser()},
                { "MG", () => new MgFileParser()},
                { "HIPEK", () => new HipekFileDetailsParser()},
                { "DYSQ", () => new DysqFileDetailParser()},
                { "KOZIU", () => new KoziuFileDetailParser()},
                { "WARRIOR", () => new WarriorFileDetailParser()},
               
            };

            //return parserFactory[path.GetName()]();
           return parserFactory[name]();
        }

    }
}
