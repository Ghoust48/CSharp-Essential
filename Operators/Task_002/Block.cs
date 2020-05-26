namespace Task_002
{
    public class Block
    {
        private int _ab;
        private int _bc;
        private int _cd;
        private int _da;

        public Block(int ab, int bc, int cd, int da)
        {
            _ab = ab;
            _bc = bc;
            _cd = cd;
            _da = da;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Block)
            {
                var block = (Block) obj;

                return _ab.Equals(block._ab) && _bc.Equals(block._bc) && _cd.Equals(block._cd) && _da.Equals(block._da);
            }

            return false;
        }

        public override string ToString()
        {
            return $"AB: {_ab}\n" +
                   $"BC: {_bc}\n" +
                   $"CD: {_cd}\n" +
                   $"DA: {_da}";
        }
    }
}