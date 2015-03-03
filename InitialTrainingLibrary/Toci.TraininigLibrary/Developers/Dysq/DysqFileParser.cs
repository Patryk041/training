using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Developers.Dysq
{
    public class DysqFileParser  //: FileParser<, DysqFileDetailParser, >
    {
     /* DysqFileEntity : FileEntityBase                             ten parser bdzie wyywolany z tego co pisalem
     * uzupelnia linie dysq file entity dzidziczaca po file entity base
     * ReadEntry
     * {
     * rozpoznawac linijke tekstowa, uzupelniac propercje DysqFileEntity
     */
        private string path = @"E:\Szkolenia\InitialTrainingLibrary\Toci.TraininigLibrary\data\";
        List<string> lines = new List<string>();
        
        public void parseMyTxtFiles()
        {
            IEnumerable<string> paths = Directory.GetDirectories(path);
        }

        public List<string> parseMyFile(FileParser<IFileSection, IFileSection, IFileSection> fileParser,
            StreamReader reader)
            {
            while (!reader.EndOfStream)
            {
                reader.ReadLine().Split(new [] "-")
            }

            }

    }
}
