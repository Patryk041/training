using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr
{
    public abstract class Parser
    {
        public abstract List<Properties> GetProperties(string atomicDefinitionOfTable);
    }
}
