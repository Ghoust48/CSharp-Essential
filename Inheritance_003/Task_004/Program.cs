using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var proKey = "pro";
            var expKey = "exp";

            Console.WriteLine("Введите ключ или нажмите Enter...");

            var input = Console.ReadLine();

            if (input == proKey)
            {
                DocumentWorker proDocumentWorker = new ProDocumentWorker();
                Show(proDocumentWorker);
            }
            else if (input == expKey)
            {
                DocumentWorker expDocumentWorker = new ExpertDocumentWorker();
                Show(expDocumentWorker);
            }
            else
            {
                var documentWorker = new DocumentWorker();
                Show(documentWorker);
            }
            
            Console.ReadKey();
        }

        private static void Show(DocumentWorker documentWorker)
        {
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}