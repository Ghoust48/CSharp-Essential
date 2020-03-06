using System;

namespace Task_002
{
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil Sudy");
        }

        public override void Read()
        {
            Console.WriteLine("BadPupil Read");
        }

        public override void Write()
        {
            Console.WriteLine("BadPupil Write");
        }

        public override void Relax()
        {
            Console.WriteLine("BadPupil Relax");
        }
    }
}