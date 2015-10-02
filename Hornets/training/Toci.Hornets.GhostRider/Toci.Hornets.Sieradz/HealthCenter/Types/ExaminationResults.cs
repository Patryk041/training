using System.Collections.Generic;
using Toci.Hornets.Sieradz.HealthCenter.Types;

namespace Toci.Hornets.Sieradz.Przychodnia.Types
{
    public class ExaminationResults
    {
        public string testExaminationName;
       public Dictionary<string, TestExaminationResults> _lablax = new Dictionary<string, TestExaminationResults>();
        
        
    }
}