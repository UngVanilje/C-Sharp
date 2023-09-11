namespace Opgave3
{
    internal class Prog24
    {
        static void Main(string[] args)
        {
            int alder;
            DateTime f;
            f = new DateTime(2000, 1, 18);
            BeregnAlder(f, out alder);
            Console.WriteLine("Alder for " + f.ToString() + ": " + alder);
            f = new DateTime(2000, 1, 19);
            BeregnAlder(f, out alder);
            Console.WriteLine("Alder for " + f.ToString() + ": " + alder);
            f = new DateTime(2000, 1, 20);
            BeregnAlder(f, out alder);
            Console.WriteLine("Alder for " + f.ToString() + ": " + alder);
            f = new DateTime(2000, 2, 17);
            BeregnAlder(f, out alder);
            Console.WriteLine("Alder for " + f.ToString() + ": " + alder);

            Console.ReadLine();
        }
        private static void BeregnAlder(DateTime foedselsdag, out int alder)
        {
            int heleaar = DateTime.Now.Year - foedselsdag.Year;
            if (DateTime.Now.Month < foedselsdag.Month || (DateTime.Now.Month == foedselsdag.Month && DateTime.Now.Day < foedselsdag.Day))
            {
                heleaar--;
            }
            alder = heleaar;
        }

    }
}
