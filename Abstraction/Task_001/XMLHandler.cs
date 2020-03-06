using System;

namespace Abstraction
{
    public class XmlHandler : AbstractHandler
    {
        public XmlHandler(string fileName)
        {
            FileName = fileName;
        }
        
        public override void Open()
        {
            Console.WriteLine($"Открыт файл {FileName} в формате xml");
        }

        public override void Create()
        {
            Console.WriteLine($"Файл {FileName}.xml создан");
        }

        public override void Change()
        {
            Console.WriteLine($"Файл {FileName}.xml изменён");
        }

        public override void Save()
        {
            Console.WriteLine($"Файл {FileName}.xml сохранён");
        }
    }
}