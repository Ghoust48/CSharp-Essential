namespace Task_003
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;
        
        public int Length { get; private set; }

        public MyDictionary(int length)
        {
            _keys = new TKey[length];
            _values = new TValue[length];
        }

        public void Add(TKey key, TValue value)
        {
            _keys[Length] = key;
            _values[Length] = value;

            Length++;
        }

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
    }
}