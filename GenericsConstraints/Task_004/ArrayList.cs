using System;
using System.Text;
using System.Text.Json;

namespace Task_004
{
    public class ArrayList
    {
        private object[] _items = null;

        public ArrayList()
        {
            _items = Array.Empty<object>();
        }

        public void Add(object item)
        {
            var arr = new object[_items.Length + 1];
            
            _items.CopyTo(arr, 0);

            _items = arr;

            _items[_items.Length - 1] = item;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < _items.Length; i++)
            {
                stringBuilder.Append(_items[i]);
                stringBuilder.Append(' ');
            }

            return $"{stringBuilder}";
        }
    }
}