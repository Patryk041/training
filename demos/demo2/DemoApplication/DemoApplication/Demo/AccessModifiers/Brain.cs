namespace DemoApplication.Demo.AccessModifiers
{
    public class Brain
    {
        protected int Neuron;

        public void cokolwiek()
        {
            Neuron = 1;
            cokolwiek();
        }


    }
}