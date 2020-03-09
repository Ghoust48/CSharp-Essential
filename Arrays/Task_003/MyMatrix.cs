namespace Task_003
{
    public class MyMatrix
    {
        private int[,] _array;
        
        public int N { get; set; }
        public int M { get; set; }

        public MyMatrix(int n, int m)
        {
            _array = new int[n, m];
        }

        public void Show()
        {
            for (int i = 0; i < _array.Length; i++)
            {
            }
        }
    }
}