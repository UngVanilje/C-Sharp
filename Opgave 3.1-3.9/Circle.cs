using System.Drawing;

namespace Opgave_3._1_3._9
{
    internal class Circle : Shape
    {
        private double radius;
        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Point getCenter()
        {
            return new Point((int)(X + radius), (int)(Y + radius));

        }

        public override double getArea()
        {
            return radius * radius * System.Math.PI;
        }

    }
}
