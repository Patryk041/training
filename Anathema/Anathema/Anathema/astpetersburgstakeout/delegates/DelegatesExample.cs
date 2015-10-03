namespace Anathema.stpetersburgstakeout.delegates
{
    public class DelegatesExample
    {
        public delegate void IamTrainingDelegate(string name);

        public IamTrainingDelegate OurDelegate;


        public void callDelegate()
        {
            OurDelegate("test");

            OurDelegate += name => name.IndexOf("fd");
        }


    }
}