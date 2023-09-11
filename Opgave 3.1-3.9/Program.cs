namespace Opgave_3._1_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new();
            Circle c1 = new(10, 10, 10);
            Circle c2 = new(20, 20, 20);
            Rectangle r1 = new(10, 10, 10, 10);
            Rectangle r2 = new(20, 20, 20, 20);

            shapes.Add(c1);
            shapes.Add(c2);
            shapes.Add(r1);
            shapes.Add(r2);

            Console.WriteLine("C1 center: " + c1.getCenter());
            Console.WriteLine("C2 center: " + c2.getCenter());


            foreach (Shape s in shapes)
            {
                Console.WriteLine("Shape: " + s + " Area: " + s.getArea());
            }
        }

    }
}
