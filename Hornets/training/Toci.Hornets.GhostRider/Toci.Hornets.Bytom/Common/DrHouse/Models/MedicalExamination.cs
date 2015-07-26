using System.Collections.Generic;

namespace Toci.Hornets.Bytom.Common.DrHouse.Models
{
    public abstract class MedicalExamination
    {
        public string Name { get; set; }
        public List<ExaminationParameter> Parameters { get; set; }
    }
}