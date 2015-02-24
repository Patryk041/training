using InitialTrainingLibrary.syf.proofsofconcept.sourcetree;

namespace InitialTrainingLibrary.warrior.conflict
{
    class ConflictType : ISourceTreeConflictType
    {
        public bool IsConflict()
        {
            return true;
        }

        public string GetName()
        {
            throw new System.NotImplementedException();
        }
    }
}
