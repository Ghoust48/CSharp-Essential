namespace Task_003
{
    public class Dictionary<TKey, TValue>
    {
        private readonly MyList<TKey> _keys;
        private readonly MyList<TValue> _values;

        public Dictionary()
        {
            _keys = new MyList<TKey>();
            _values = new MyList<TValue>();
        }

        public TValue this[TKey key]
        {
            get
            {
                for (var i = 0; i < _keys.Count; i++)
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
                for (var i = 0; i < _values.Count; i++)
                {
                    if (_values[i].Equals(value))
                    {
                        return _keys[i];
                    }
                }

                return default;
            }
        }
    
        public void Add(TKey key, TValue value)
        {
            _keys.Add(key);
            _values.Add(value);
        }

        public int Count => _keys.Count;
    }
}