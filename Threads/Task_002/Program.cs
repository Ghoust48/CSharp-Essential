using System;
using System.Text;
using System.Threading;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);

            Matrix matrix;

            for (var i = 0; i < 30; i++)
            {
                matrix = new Matrix(i * 2);
                new Thread(matrix.Move).Start();
            }

            Console.ReadLine();
        }

    }
}
