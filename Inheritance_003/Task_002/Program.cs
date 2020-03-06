using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var classRoom = new ClassRoom(new BadPupil(), new ExcelentPupil());
            
            classRoom.Study();
            classRoom.Read();
            classRoom.Write();
            classRoom.Relax();
            
            Console.ReadLine();
        }
    }
}