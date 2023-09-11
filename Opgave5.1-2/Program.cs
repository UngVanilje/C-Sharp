namespace Opgave5._1_2
{
    public class Program
    {

        private static void FindPåListenAfInts()
        {
            List<int> list = new()
            {
                1,
                4,
                7,
                2,
                5,
                11,
                14,
                21,
                17
            };

            List<int> result = list.FindAll(i => i % 2 == 0);
            Console.WriteLine("Alle tal % 2 = 0");
            result.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();

            int last = list.FindLast(i => i > 15);
            Console.WriteLine("Sidste tal over 15: " + last);

            int lastIndex = list.FindLastIndex(i => i > 15);
            Console.WriteLine("Index på sidste tal over 15: " + lastIndex);

        }

        private static void FindPåListenAfIntsLINQ()
        {
            List<int> list = new()
            {
                1,
                4,
                7,
                2,
                5,
                11,
                14,
                21,
                17
            };

            IEnumerable<int> result = list.Where(i => i % 2 == 0);
            Console.WriteLine("(Method)Alle tal % 2 = 0: ");
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            IEnumerable<int> result2 = list.Where(i => i % 2 == 0).OrderByDescending(i => i);
            Console.WriteLine("(Method)Alle tal % 2 = 0, sorteret faldende: ");
            foreach (int i in result2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            IEnumerable<int> result3 = list.Where(i => i.ToString().Length == 2);
            Console.WriteLine("(Method)Alle tal med to cifre: ");
            foreach (int i in result3)
            {
                Console.WriteLine(i);
            }

            // Query syntax for result (even numbers)
            IEnumerable<int> result4 = from i in list
                                       where i % 2 == 0
                                       select i;

            Console.WriteLine("(Query)Alle tal % 2 = 0: ");
            foreach (int i in result4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Query syntax for result2 (even numbers, sorted in descending order)
            IEnumerable<int> result5 = from i in list
                                       where i % 2 == 0
                                       orderby i descending
                                       select i;

            Console.WriteLine("(Query)Alle tal % 2 = 0, sorteret faldende: ");
            foreach (int i in result5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Query syntax for result3 (numbers with two digits)
            IEnumerable<int> result6 = from i in list
                                       where i >= 10 && i <= 99
                                       select i;

            Console.WriteLine("(Query)Alle tal med to cifre: ");
            foreach (int i in result6)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            FindPåListenAfInts();
            Console.WriteLine();
            FindPåListenAfIntsLINQ();


        }

    }
}