using System;

namespace Abstraction
{
    public class TxtHandler : AbstractHandler
    {
        public TxtHandler(string fileName)
        {
            FileName = fileName;
        }
        
        public override void Open()
        {
            Console.WriteLine($"Открыт файл {FileName} в формате txt");
        }

        public override void Create()
        {
            Console.WriteLine($"Файл {FileName}.txt создан");
        }

        public override void Change()
        {
            Console.WriteLine($"Файл {FileName}.txt изменён");
        }

        public override void Save()
        {
            Console.WriteLine($"Файл {FileName}.txt сохранён");
        }
    }
}