namespace Opgave_3._1_3._9
{
    internal class Rectangle : Shape
    {
        private double width, height;
        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public override double getArea()
        {
            return width * height;
        }
    }
}
