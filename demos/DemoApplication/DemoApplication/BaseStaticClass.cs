namespace DemoApplication
{
    public  class BaseStaticClass
    {
        public static void AttemptToOveeride()
        {
            //this.test();
        }

        public void test()
        {
            AttemptToOveeride();
        }
    }
}