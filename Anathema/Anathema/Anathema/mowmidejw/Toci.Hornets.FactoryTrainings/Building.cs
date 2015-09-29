namespace Toci.Hornets.FactoryTrainings
{
    public abstract class Building : IBuilding
    {
      

        public string BuildName { get; set; }
        public int Area { get; set; }

        public bool SecurityProvided()
        {
            return true;
        }

        public abstract string Description();
    }
}