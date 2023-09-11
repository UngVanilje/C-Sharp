namespace Opgave_3._1_3._9
{
    internal abstract class Shape
    {

        private double x, y;
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Shape() : this(10, 10) { }

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public abstract double getArea();
    }
}
