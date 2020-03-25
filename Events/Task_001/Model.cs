using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_001
{
    class Model
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Dirive(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }

            return a / b;
        }
    }
}
