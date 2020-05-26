using System;

namespace Task_002
{
    public class Workers
    {
        private Worker[] _workers;
        
        public Workers()
        {
            _workers = new Worker[5];
        }

        public void Read()
        {
            var isWork = false;
            
            for (var i = 0; i < _workers.Length; i++)
            {
                _workers[i] = new Worker();
                
                Console.WriteLine("Введите информацию о работнике");

                Console.Write("Фамилия и инициалы: ");
                _workers[i].FIO = Console.ReadLine();
                
                Console.Write("Название занимаемой должности: ");
                _workers[i].JobTitle = Console.ReadLine();

                do
                {
                    try
                    {
                        Console.Write("Год поступления на работу: ");
                        _workers[i].Date = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);
                        isWork = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Не верный формат!");
                        isWork = true;
                    }
                } while (isWork);
                
                Console.WriteLine(new string('-', 20));
            }
        }
        
        public void ShowFIO()
        {
            Console.Write("Введите стаж: ");
            var experience = int.Parse(Console.ReadLine());
            
            foreach (var worker in _workers)
            {
                var experienceNow = DateTime.Now.Year - worker.Date.Year;
                
                if (experienceNow > experience)
                {
                    Console.WriteLine(worker.FIO);
                }
            }
        }
        
        public void Sort()
        {
            for (var i = 0; i < _workers.Length; i++)
            {
                for (var j = i + 1; j < _workers.Length; j++)
                {
                    if (string.Compare(_workers[i].FIO, _workers[j].FIO, StringComparison.Ordinal) > 0 )
                    {
                        var tmp = _workers[i];
                        _workers[i] = _workers[j];
                        _workers[j] = tmp;
                    }
                }
            }
        }
    }
}