using System;
using System.Collections;
using System.Collections.Generic;
using Anathema.Lurppis;
using Anathema.Mati;

namespace Anathema.Generics
{
    public class GRList<T> : IEnumerable<T>
    {
        private T[] _items = new T[10];
        //
        private int _index = 0;

        public virtual bool AddElement(T item, bool unique = true)
        {
            // 
            //Array.Copy();
            
            _items[_index] = item;

            return true;
        }

        public virtual T[] GetAllItems()
        {
            return _items;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class MicroBrainFuck<T>
    {
        public void PopulateList()
        {
            GRList<MyClass> ListofLurpis = new GRList<MyClass>();
            GRList<MyNewClass> MyNewClass = new GRList<MyNewClass>();

            GRList<GhostRiderBase> korekta = new GRList<GhostRiderBase>();

            korekta.AddElement(new MyNewClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());
            korekta.AddElement(new MyClass());

            foreach (var item in korekta)
            {
                item.GetBankName();
            }


            var items = new GRList<GRList<GhostRiderBase>>();

            //items.AddElement(ListofLurpis);
            //items.AddElement(MyNewClass);

        }
    }
}