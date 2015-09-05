using System;
using System.Collections;
using System.Collections.Generic;

namespace Anathema.Erllon
{
    public class ErloonList<T>:ICollection<T>,IEnumerator<T>
    {
        private T[] _elements;
        private T[] _removeElements;
        private T[] _tempArray;
        private int _index;
        private int _capacity;
        private int _size;
        private int _position = -1; //MoveNext

        public ErloonList()
        {
            _elements = new T[10];
            _removeElements = new T[10];
            _capacity = 10;
            _size = 0;

        }

        public ErloonList(int capacity)
        {
            _elements = new T[capacity];
            _removeElements = new T[capacity - 1];
            _capacity = capacity;
            _size = 0;
        }


        //Wyliczanie po kolekcji
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var t in _elements)
            {
                if (t == null)
                {
                    break;
                }
                yield return t;
            }
            //Tez nie działa
            // return (IEnumerator<T>)this._elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Clear()
        {
            _elements = new T[_capacity];
            _size = 0;
            Reset();
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (this[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        //Indekser
        public T this[int index]
        {
            get { return _elements[index]; }
            set { _elements[index] = value; }
        }

        public void CopyTo(T[] array, int index)
        {
            foreach (var item in this)
            {
                array.SetValue(item, index);
                index++;
            }

        }

        public bool Remove(T item)
        {

            for (int i = 0; i < _size; i++)
            {
                if (_elements[i].Equals(item))
                {
                    Array.Copy((Array)this._elements, i + 1, (Array)this._removeElements, i, this._elements.Length - i);
                    return true;
                }
            }
            return false;
        }

        public int Count
        {
            get { return this._elements.Length; }
        }

        public bool IsReadOnly { get; private set; } //set musi być, ale prywatny, wtedy nie ma do niego dostępu z zewnątrz == readonly
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _elements.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Add(T item)
        {
            if (_index == _elements.Length)
            {
                Array.Resize(ref _elements, _elements.Length + 1);
            }
            _elements[_index] = item;
            _index++;
        }

        public T Current
        {
            get { return _elements[_position]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}