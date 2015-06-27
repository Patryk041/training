namespace DemoApplication.chess
{
    public abstract class Figure
    {
        private int iamnotderiving;
        private int colour;
        protected int iamderiving;

        public string autoproperta { get; set; }

        
        public abstract void Move(Coordinates destination);

        public void dowolna()
        {
            //this.
        }

        public static void test2()
        {
            
        }
    }
}