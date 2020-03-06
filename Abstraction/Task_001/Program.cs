using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла: ");
            var fileName = Console.ReadLine();

            Console.WriteLine("1. XML\n" +
                              "2. Txt\n" +
                              "3. Doc\n");

            var input = int.Parse(Console.ReadLine());
            AbstractHandler file = null;

            switch (input)
            {
                case 1:
                    Show(new XmlHandler(fileName));
                    break;
                case 2: 
                    Show(new TxtHandler(fileName));
                    break;
                case 3:
                    Show(new DocHandler(fileName));
                    break;
            }

            Console.ReadLine();
        }

        private static void Show(AbstractHandler file)
        {
            file.Create();
            file.Open();
            file.Change();
            file.Save();
        }
    }
}