using System;
using System.Collections.Generic;

namespace Task_002
{
    public class CarCollection<T> where T : Car
    {
        private readonly MyList<Car> _cars; 
        // private readonly MyList<T> _cars; 

        public CarCollection()
        {
            _cars = new MyList<Car>();
            // _cars = new MyList<T>();
        }

        public int Count => _cars.Count;

        public void Add(string name, DateTime date)
        {
            // var car = new Car(name, date); 
            // _cars.Add(car as T);
            
            _cars.Add(new Car(name, date));
        }

        public T this[int index] => (T) _cars[index];
    }
}