namespace Anathema.Lurppis.Wzorce.Sngleton
{
    public class Singleton
    {
        // Przechowujemy utworzony ewentualny obiekt
        private static Singleton _singleton;

        // Konstruktor musi byc private albo protected aby uniemozliwic
        //  utworzenie obiektu za pomoca operatora new

        private Singleton(){}

        // Publicza statyczna metoda za pomoca ktorej utworzymy referencje do obiekti

        public static Singleton UtworzObiektSingleton()
        {
            if(_singleton == null)
            _singleton = new Singleton();
            
            return _singleton;
        }
    }
}