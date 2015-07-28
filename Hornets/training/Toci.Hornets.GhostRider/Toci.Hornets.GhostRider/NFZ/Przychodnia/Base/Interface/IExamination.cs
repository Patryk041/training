using System.Collections.Generic;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Types;

namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface
{
    public interface IExamination<TResult>
    {
        Examination GetExaminationData();
        Dictionary<string, TResult> GetResultDictionary();
    }
}