namespace Opgave4._2
{

    public delegate void Warning(int temperature);
    internal class Program
    {
        public static List<String> warnings = new List<String>();
        static void Main(string[] args)
        {
            PowerPlant plant = new PowerPlant();
            plant.SetWarning(warningToConsole);
            //plant.addWarning(warningToConsole);
            //plant.addWarning(warningToSomewhereElse);
            for (int i = 0; i < 10; i++)
            {
                plant.HeatUp();
            }

            //foreach (string warning in warnings)
            //{
            //    Console.WriteLine(warning);
            //}
            Console.ReadLine();
        }
        private static void warningToConsole(int t)
        {
            Console.WriteLine("Advarsel, temperaturen er " + t);
        }
        private static void warningToSomewhereElse()
        {
            warnings.Add("Advarsel i liste");
        }
    }
    public class PowerPlant
    {
        private Warning _Warning;
        Random random = new Random();

        public void addWarning(Warning wa)
        {
            _Warning += wa;
        }
        public void SetWarning(Warning wa)
        {
            _Warning = wa;
        }
        public void HeatUp()
        {

            int t = random.Next(100);
            if (t > 50)
            {
                _Warning.Invoke(t);
            }
        }
    }
}