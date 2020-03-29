using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_003
{
    public class MyDictionary<TKey, TValue> : IEnumerable<TKey>
    {
        private TKey[] _keys;

        private TValue[] _values;

        private int _count = 5;

        private int _position = -1;

        public MyDictionary()
        {
            _keys = new TKey[_count];
            _values = new TValue[_count];
        }

        public int Length { get; private set; }

        public void Add(TKey key, TValue value)
        {
            if (Length < _count)
            {
                _keys[Length] = key;
                _values[Length] = value;
                Length++;
            }
            else
            {
                var keys = new TKey[_count * 2];
                var values = new TValue[_count * 2];

                _keys.CopyTo(keys, 0);
                _values.CopyTo(values, 0);

                _keys = keys;
                _values = values;

                _keys[Length] = key;
                _values[Length] = value;

                Length++;
            }
        }

        #region Индексаторы

        public TValue this[TKey key]
        {
            get
            {
                for (var i = 0; i < _keys.Length; i++)
                {
                    if (_keys[i].Equals(key))
                    {
                        return _values[i];
                    }
                }

                return default;
            }
        }

        public TKey this[TValue value]
        {
            get
            {
                for (var i = 0; i < _values.Length; i++)
                {
                    if (_values[i].Equals(value))
                    {
                        return _keys[i];
                    }
                }

                return default;
            }
        }

        public void Reset()
        {
            _position = -1;
        }

        #endregion

        #region Реализация интерфесов 

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<TKey>).GetEnumerator();
        }

        IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
        {
            while (true)
            {
                if (_position < _keys.Length - 1)
                {
                    _position++;
                    yield return _keys[_position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }

        #endregion
    }
}
