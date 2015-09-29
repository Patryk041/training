using System;

namespace Anathema.Lurppis.Wzorce.MetodaSzablonowa.Szablon
{
    abstract class AbstractClass
    {
        /*
            Nasza klasa składa się z pięciu metod.
            Najważniejsza jest metoda szablonowa Run,
            która operuje na czterech składowych.
            Metody OperationA oraz OperationB są nie zaimplementowane i
            ich implementacja musi się pojawić w klasach potomnych.
            Metody OperationC oraz OperationD są już zdefiniowane i
            istnieje techniczna możliwość przesłonięcia metody
            OperationD (dzięki zastosowaniu słówka kluczowego Virtual).
            Możemy oczywiście też korzystać z bazowej implementacji.
        */

        protected abstract void OperationA();
        protected abstract void OperationB();

        protected void OperationC()
        {
            Console.WriteLine("AbstractClass.OperationC");
        }

        protected virtual void OperationD()
        {
            Console.WriteLine("AbstractClass.OperationD");
        }

        public void Run()
        {
            OperationA();
            OperationB();
            OperationC();
            OperationD();
        }
    }
}