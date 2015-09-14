using System.Collections.Generic;
using System.Linq;
using Anathema.Patryk.TrainingTwo.Utils;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract
{

    //Klasa, która na podstawie pliku tekstowego zwroci List<TResult> ( w naszym przypadku TResult == BankTransfer
    public abstract class TxtParser<TResult> : IDocumentParser<TResult>
    {
        protected FileOperations FileOperations;
        private char _splitter;


        //dzieki zastosowaniu argumentu domyślnego klasy dziedziczace maja mozliwosc
        //zmiany znaku, ktorym bedziemy dzielic tekst, ale nie musza tego robic
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
            //odczytanie calego tekstu z pliku
            string fileContent = FileOperations.ReadAllContent(path);

            //podzielenie otrzymanego tekstu na kawalki (w naszym przypadku na wiersze)
            return fileContent.Split(_splitter).ToList();
        }

        //dostarzcenie obiektu TResult na podstawie otrzymanego kawałku tekstu (w naszym przypadku na wiersza)
        protected abstract TResult GetResult(string entry);
    }
}