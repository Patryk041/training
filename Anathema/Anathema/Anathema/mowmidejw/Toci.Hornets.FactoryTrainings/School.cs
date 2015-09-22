namespace Toci.Hornets.FactoryTrainings
{
    public class School : Building
    {
       public School()
       {
           BuildName = "school";
       }

        public override string Description()
        {
            return "School is the place, where your children spend a lot of time, and have fun!";
        }
    }
}