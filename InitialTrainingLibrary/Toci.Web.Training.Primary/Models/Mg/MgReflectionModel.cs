namespace Toci.Web.Training.Primary.Models.Mg
{
    public class MgReflectionModel
    {

        public string Number { get; private set; }
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string Description { get; private set; }
        private string car;

        public string GetCar()
        {
            return car;
        }
    }
}