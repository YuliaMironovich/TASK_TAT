namespace test1_task4
{
    /// <summary>
    /// Class contains information about coordinates.
    /// You can set in the field of structure only certain coordinate values.
    /// </summary>
    public class Coordinate
    {
        private char x;
        private int y;

        public char X
        {
            get
            {
                return x;
            }
            set
            {
                if ((value >= 'A') && (value <= 'J'))
                {
                    x = value;
                }
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if ((value >= 1) && (value <= 10))
                {
                    y = value;
                }
            }
        }

        public Coordinate(char x, int y)
        {
            X = x;
            Y = y;
        }
        
    }
}
