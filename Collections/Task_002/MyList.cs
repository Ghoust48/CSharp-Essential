using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_002
{
    public class MyList<T> : IEnumerable<T>
    { 
        private T[] _list = null;

        private int _position = -1;

        private int _count = 5;

        public MyList()
        {
            _list = new T[_count];
        }

        public int Length { get; private set; }

        public void Add(T element)
        {
            if (Length < _count)
            {
                _list[Length] = element;
                Length++;
            }
            else
            {
                var list = new T[_count * 2];

                _list.CopyTo(list, 0);

                _list = list;

                _list[Length] = element;
                Length++;
            }
            
        }

        public T this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }

        public void Reset()
        {
            _position = -1;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            while (true)
            {
                if (_position < _list.Length - 1)
                {
                    _position++;
                    yield return _list[_position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }
    }
}
