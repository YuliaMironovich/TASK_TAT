namespace DEV_7
{
    abstract public class Triangle
    {
        private double a, b, c;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public abstract string GetType();
    }   
}
