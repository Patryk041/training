namespace Toci.Hornets.FactoryTrainings
{
    public class Cinema : Building
    {
        public Cinema()
        {
            BuildName = "cinema";
            Area = 33871;
        }

        public override string Description()
        {
            return "Do You want watch interesting film? We invite You to our cinema!";
        }
    }
}