using System.Collections.Generic;
using System.Linq;
using Anathema.Patryk.TrainingTwo.Utils;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract
{

    public abstract class TxtParser<TResult> : DocumentParser<TResult,string>
    {
        protected FileOperations FileOperations;
        private char _splitter;

        protected TxtParser(char splitter = '\n')
        {
            FileOperations = new FileOperations();
            _splitter = splitter;
        }


        protected override List<string> GetEntries(string path)
        {

            string fileContent = FileOperations.ReadAllContent(path);
            return fileContent.Split(_splitter).ToList();
        }
    }
}