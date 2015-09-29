using System;

namespace Anathema.Lurppis.Wzorce.MetodaSzablonowa.Szablon
{
    class ClassSecond : AbstractClass
    {
        protected override void OperationA()
        {
            Console.WriteLine("ClassSecond.OperationA");
        }
        protected override void OperationB()
        {
            Console.WriteLine("ClassSecond.OperationB");
        }
    }
}