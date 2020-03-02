using System;

namespace Task_002
{
    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil Sudy");
        }

        public override void Read()
        {
            Console.WriteLine("GoodPupil Read");
        }

        public override void Write()
        {
            Console.WriteLine("GoodPupil Write");
        }

        public override void Relax()
        {
            Console.WriteLine("GoodPupil Relax");
        }
    }
}