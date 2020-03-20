using System;
using System.Text;

namespace Task_002
{
    public class MyList<T> : IMyList<T>
    {
        private T[] array = null;

        public MyList()
        {
            array = new T[0];
        }


        public void Add(T a)
        {
            var arr = new T[array.Length + 1];
            
            array.CopyTo(arr, 0);

            array = arr;

            array[array.Length - 1] = a;
            
        }

        public T this[int index] => array[index];

        public int Count => array.Length;

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < array.Length; i++)
            {
                stringBuilder.Append(array[i]);
                stringBuilder.Append(' ');
            }

            return $"Количество элементов: {Count}\n" +
                   $"Значения: {stringBuilder}\n";
        }
    }
}