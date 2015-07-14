namespace DemoApplication.Demo.AccessModifiers
{
    public class Eye
    {
        protected Brain Brain;
        private int colour;

//        public Eye(Brain brain)
//        {
//            Brain = brain;
//        }

        public void See()
        {
            colour = 4;
            Brain.cokolwiek();
        }

        public void ChangeColour(Eye anotherEye)
        {
            anotherEye.colour = 543;
        }
    }
}