using System;
using System.Collections.Generic;

namespace Task_002
{
    public class MyArray
    {
        private int[] _array;
        
        public MyArray(int length)
        {
            _array = new int[length];
        }
        
        public void Fill()
        {
            var rand = new Random();
            
            for (var i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(-10, 10);
            }
        }

        public void Show()
        {
            for (var i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }

            Console.WriteLine(new string('-', 20));
        }

        public void Max()
        {
            var max = 0;
            
            for (var i = 0; i < _array.Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(new string('-', 20));
        }

        public void Min()
        {
            var min = 0;

            for (var i = 0; i < _array.Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(new string('-', 20));
        }

        public void Sum()
        {
            var sum = 0;
            
            for (var i = 0; i < _array.Length; i++)
            {
                sum += _array[i];
            }

            Console.WriteLine(sum);
            Console.WriteLine(new string('-', 20));
        }

        public void Average()
        {
            var sum = 0;
            
            for (var i = 0; i < _array.Length; i++)
            {
                sum += _array[i];
            }
            
            Console.WriteLine(sum / _array.Length);
            Console.WriteLine(new string('-', 20));
        }

        public void Odd()
        {
            for (var i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 != 0)
                {
                    Console.WriteLine(_array[i]);
                }
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}