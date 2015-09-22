using System.Collections.Generic;
using System.Linq;
using Anathema.Patryk.TrainingTwo.Utils;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract
{

    public abstract class TxtParser<TResult> : IDocumentParser<TResult>
    {
        protected FileOperations FileOperations;
        private char _splitter;

        protected TxtParser(char splitter = '\n')
        {
            FileOperations = new FileOperations();
            _splitter = splitter;
        }

        public virtual List<TResult> GetAllResults(string path)
        {
            return GetEntires(path).Select(GetResult).ToList();
        }


        protected virtual List<string> GetEntires(string path)
        {

            string fileContent = FileOperations.ReadAllContent(path);
            return fileContent.Split(_splitter).ToList();
        }

        protected abstract TResult GetResult(string entry);
    }
}