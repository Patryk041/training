namespace Anathema.marcin022
{
    public class Test
    {
        public void TestMethod()
        {
            ListGeneric<Class1> lista = new ListGeneric<Class1>();
            for (int i = 0; i <= 15; i++)
            {
                lista.Add(new Class1());
            }
        } 
    }
}