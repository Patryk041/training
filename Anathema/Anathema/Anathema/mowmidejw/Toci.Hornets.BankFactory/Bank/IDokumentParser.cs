using System.Collections.Generic;
namespace Toci.Hornets.BankFactory.Bank
{
        public interface IDocumentParser<TResult>
        {
            List<TResult> GetAllResults(string path);

        }
    }