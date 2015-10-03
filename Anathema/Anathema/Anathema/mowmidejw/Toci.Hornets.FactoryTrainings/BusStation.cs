namespace Toci.Hornets.FactoryTrainings
{
    public class BusStation : Building
    {
        public BusStation()
        {
            BuildName = "bus station";
        }

        public override string Description()
        {
            return "We always find the best direction!";
        }
    }
}