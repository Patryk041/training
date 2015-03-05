using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Base.InternetStore;

namespace Toci.TraininigLibrary.Developers.Koziu.InternetStore
{
    public class KoziuBinCollection :BinBaseCollection
    {
        //Dictionary<string, KoziuBin> koziuBins = new Dictionary<string, KoziuBin>();

        public void AddBin(string key, KoziuBin bin)
        {
            this.Add(key, bin);
        }

        public Dictionary<string, BinBase> Bins()
        {
            return this;
        }
    }
}
