namespace Anathema.Patryk.TrainingOne.Cars.Abstract
{
    public abstract class Car : ICar
    {
        public bool TryDrive()
        {
            if (!CanDrive()) return false;
            Drive();
            return true;
        }

        public abstract bool CanDrive();
        
        public abstract void Drive();

        public Color Color { get; set; }
        public string Description { get; set; }
    }
}