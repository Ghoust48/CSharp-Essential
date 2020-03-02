using System;

namespace Task_002
{
    public class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil Sudy");
        }

        public override void Read()
        {
            Console.WriteLine("ExcelentPupil Read");
        }

        public override void Write()
        {
            Console.WriteLine("ExcelentPupil Write");
        }

        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil Relax");
        }
    }
}