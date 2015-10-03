using System.Collections.Generic;
using System.Linq;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract
{
    public abstract class DocumentParser<TResult, TEntry> : IDocumentParser<TResult>
    {

        public List<TResult> GetAllResults(string path)
        {
            return GetEntries(path).Select(GetResult).ToList();
        }

        protected abstract List<TEntry> GetEntries(string path);


        protected abstract TResult GetResult(TEntry nodes);
         
    }
}