using System;

namespace Task_002
{
    public class ClassRoom
    {
        private Pupil[] _pupils = new Pupil[4];
        
        public ClassRoom(Pupil p1, Pupil p2)
        {
            _pupils[0] = p1;
            _pupils[1] = p2;
            _pupils[2] = RandomPupil();
            _pupils[3] = RandomPupil();
        }
        
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            _pupils[0] = p1;
            _pupils[1] = p2;
            _pupils[2] = p3;
            _pupils[3] = RandomPupil();
        }
        
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            _pupils[0] = p1;
            _pupils[1] = p2;
            _pupils[2] = p3;
            _pupils[3] = p4;
        }

        private Pupil RandomPupil()
        {
            var rand = new Random();
            var index = rand.Next(1, 4);

            return index switch
            {
                1 => new ExcelentPupil(),
                2 => new GoodPupil(),
                3 => new BadPupil()
            };
        }
        
        public void Study()
        {
            foreach (var pupil in _pupils)
            {
                pupil.Study();
            }
        }

        public void Read()
        {
            foreach (var pupil in _pupils)
            {
                pupil.Read();
            }
        }

        public void Write()
        {
            foreach (var pupil in _pupils)
            {
                pupil.Write();
            }
        }

        public void Relax()
        {
            foreach (var pupil in _pupils)
            {
                pupil.Relax();
            }
        }
    }
}