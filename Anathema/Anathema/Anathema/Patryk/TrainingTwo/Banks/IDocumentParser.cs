using System.Collections.Generic;

namespace Anathema.Patryk.TrainingTwo.Banks
{
    public interface IDocumentParser<TResult>
    {
        List<TResult> GetAllResults(string path);

    }
}