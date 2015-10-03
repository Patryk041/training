using System;

namespace Anathema.Lurppis.Wzorce.MetodaSzablonowa.Szablon
{
    class ClassFirst : AbstractClass
    {
        protected override void OperationA()
        {
            Console.WriteLine("ClassFirst.OperationA");
        }
        protected override void OperationB()
        {
            Console.WriteLine("ClassFirst.OperationB");
        }

        protected override void OperationD()
        {
            Console.WriteLine("ClassFirst.OperationD");
        }
    }
}