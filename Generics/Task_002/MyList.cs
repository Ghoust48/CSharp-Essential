namespace Task_002
{
    public class MyList<T>
    {
        private T[] _list;
        
        public int Length { get; private set; }

        public MyList()
        {
            _list = new T[5];
        }

        public void Add(T element)
        {
            _list[Length] = element;
            Length++;
        }

        public T this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }
    }
}