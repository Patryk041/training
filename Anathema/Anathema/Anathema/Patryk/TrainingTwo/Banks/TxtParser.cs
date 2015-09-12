using System.Collections.Generic;
using System.Linq;

namespace Anathema.Patryk.TrainingTwo.Banks
{
    public abstract class TxtParser<TResult> : IDocumentParser<TResult>
    {
         protected FileOperations FileOperations;
        protected char Splitter;

         protected TxtParser(char splitter = '\n')
        {
            FileOperations = new FileOperations();
             Splitter = splitter;
        }

         public virtual List<TResult> GetAllResults(string path)
        {
            return GetEntires(path).Select(GetResult).ToList();
        }


        protected virtual List<string> GetEntires(string path)
        {
            string fileContent = FileOperations.ReadAllContent(path);
            return fileContent.Split(Splitter).ToList();
        }


        protected abstract TResult GetResult(string entry);
    }
}