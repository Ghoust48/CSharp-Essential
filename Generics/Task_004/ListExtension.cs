namespace Task_004
{
    public static class ListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var arr = new T[list.Length];
            
            for (var i = 0; i < list.Length; i++)
            {
                arr[i] = list[i];
            }

            return arr;
        }
    }
}