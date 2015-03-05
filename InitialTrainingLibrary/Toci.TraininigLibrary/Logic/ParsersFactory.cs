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
using Toci.TraininigLibrary.Developers.Mg;
using Toci.TraininigLibrary.Developers.RS.FileParser;
using Toci.TraininigLibrary.Developers.Santi.FileParser;

namespace Toci.TraininigLibrary.Logic
{
    public class ParsersFactory
    {
        /// <summary>
        /// Zwraca listę obiektów typu EntityBase (pojedyńczy rekord). Argument = string [] directotryPaths
        /// </summary>
        /// <param name="path"></param>
        public List<FileEntityBase> GetData(string[] directoryPaths)
        {
         List<FileEntityBase> entityBaseList = new List<FileEntityBase>();

            string[] temp = new string[1];
            foreach (var x in directoryPaths)
            {
                if (x.GetName().Contains("DOMI")) temp[0] = x;
            }

            temp.AsParallel().WithDegreeOfParallelism(5).ForAll(i => entityBaseList.Add(GetProperParser(i.GetName()).ReadEntry("Dominika;Dziurzynska;2015-03-13;13039302007")));

         return entityBaseList;
        }

       // private FileDetailParserBase GetProperParser(string path)
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
               
            };

            //return parserFactory[path.GetName()]();
           return parserFactory[name]();
        }

    }
}
