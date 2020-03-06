using System;

namespace Abstraction
{
    public class DocHandler : AbstractHandler
    {
        public DocHandler(string fileName)
        {
            FileName = fileName;
        }
        
        public override void Open()
        {
            Console.WriteLine($"Открыт файл {FileName} в формате doc");
        }

        public override void Create()
        {
            Console.WriteLine($"Файл {FileName}.doc создан");
        }

        public override void Change()
        {
            Console.WriteLine($"Файл {FileName}.doc изменён");
        }

        public override void Save()
        {
            Console.WriteLine($"Файл {FileName}.doc сохранён");
        }
    }
}