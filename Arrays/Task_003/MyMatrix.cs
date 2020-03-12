using System;

namespace Task_003
{
    public class MyMatrix
    {
        private int[][] _matrix;

        public MyMatrix(int n, int m)
        {
            _matrix = new int[Math.Abs(n)][];

            for (var i = 0; i < Math.Abs(n); i++)
            {
                _matrix[i] = new int[Math.Abs(m)];
            }
            
            Fill();
        }

        public void Fill()
        {
            var rand = new Random();

            for (var i = 0; i < _matrix.Length; i++)
            {
                for (var j = 0; j < _matrix[i].Length; j++)
                {
                    _matrix[i][j] = rand.Next(10, 90);
                }
            }
        }

        public void ChangeSize(int row, int col)
        {
            if (row <= 0 || col <= 0)
            {
                Console.WriteLine("Размеры матрици не могут быть меньшими или равными нулю");
                return;
            }

            var mNew = new int[row][];

            for (var i = 0; i < row; i++)
                mNew[i] = new int[col];

            for (var i = 0; i < Math.Min(_matrix.Length, row); i++)
            {
                for (var j = 0; j < Math.Min(_matrix[i].Length, col); j++)
                {
                    mNew[i][j] = _matrix[i][j];
                }
            }

            var rand = new Random();
            
            if (row > _matrix.Length)
            {
                for (var i = _matrix.Length; i < row; i++)
                {
                    for (var j = 0; j < Math.Min(col, _matrix[0].Length); j++)
                    {
                        mNew[i][j] = rand.Next(10, 90);
                    }
                }
            }

            if (col > _matrix[0].Length)
            {
                for (var i = _matrix[0].Length; i < col; i++)
                {
                    for (var j = 0; j < row; j++)
                    {
                        mNew[j][i] = rand.Next(10, 90);
                    }
                }
            }

            _matrix = mNew;
        }

        public void ShowPartly(int startRow, int startCol, int endRow, int endCol)
        {
            if (startRow < 0 || startCol < 0 || endRow > _matrix.Length || endCol > _matrix[0].Length)
            {
                Console.WriteLine("Попытка обращения за пределы массива.");
                return;
            }

            if (startRow > endRow || startCol > endCol)
            {
                Console.WriteLine("Неверно заданы координаты конечной точки");
                return;
            }

            for (var i = startRow; i < endRow; i++)
            {
                for (var j = startCol; j < endCol; j++)
                {
                    Console.Write("{0}  ", _matrix[i][j]);
                }
                
                Console.Write("\n");
            }
        }

        public void Show()
        {
            ShowPartly(0, 0, _matrix.Length, _matrix[0].Length);
        }

        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 < _matrix.Length && index2 >= 0 && index2 < _matrix[0].Length)
                    return _matrix[index1][index2];
                
                Console.WriteLine("Попытка обращения за пределы массива.");
                return 0;
            }

            set
            {
                if (index1 >= 0 && index1 < _matrix.Length && index2 >= 0 && index2 < _matrix[0].Length)
                {
                    _matrix[index1][index2] = value;

                }
                else
                {
                    Console.WriteLine("Попытка записи за пределами массива.");
                }
            }
        }
    }
}