using System.Collections.Generic;
using System.Linq;

namespace Task_004
{
    static class ExtensionMyList
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            var enumerator = list.GetEnumerator();
            var arr = new T[list.Count()];

            var i = 0;

            while (enumerator.MoveNext())
            {
                arr[i] = enumerator.Current;
                i++;
            }

            return arr;
        }
    }
}
