using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Mg.Polymorphism.Parsers;


namespace Toci.TraininigLibrary.Developers.Mg.Polymorphism
{
    public class MgParsersFactory
    {
        public IMgTransferParser GetProperParser(string path)
        {
            GetExtension(ref path);

            Dictionary<string, Func<IMgTransferParser>> parsersFactoryDictionary = new Dictionary<string, Func<IMgTransferParser>>
                ()
            {
                {"TXT", () => new MgTxtTransferParser()},
                {"XML", () => new MgXmlTransferParser()}
            };

            return parsersFactoryDictionary[path]();
        }

        private void GetExtension(ref string path)
        {
            path = path.Substring(path.Length - 3, 3).ToUpper();
        }
    }
}





