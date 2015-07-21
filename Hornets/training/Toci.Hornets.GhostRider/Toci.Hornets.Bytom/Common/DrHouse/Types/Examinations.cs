using System.Collections.Generic;

namespace Toci.Hornets.Bytom.Common.DrHouse.Types
{
    public abstract class Examinations
    {
        public string Name { get; set; }
        public List<ExaminationParameter> Parameters { get; set; }
    }
}