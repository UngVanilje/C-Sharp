namespace Opgave5._3
{
    internal class Program
    {
        public static void GetListOfPeople()
        {

            //Til opgave 5.8-9
            int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

            //Opgave 5.10
            IList<int> randomNumbers = new List<int>();
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                randomNumbers.Add(random.Next(1, 100));
            }
            //Til 5.3-5.7
            int counter = 0;
            List<Person> people1 = new();
            List<Person> people2 = new();
            try
            {   //til den bærbare
                people1 = Person.ReadCSVFile("C:\\Users\\caspe\\OneDrive\\Documents\\EAA skole\\C#\\4.Semester\\Opgave5.3\\data1.csv");
                people2 = Person.ReadCSVFile("C:\\Users\\caspe\\OneDrive\\Documents\\EAA skole\\C#\\4.Semester\\Opgave5.3\\data2.csv");

                //Til pc
                //people1 = Person.ReadCSVFile("D:\\caspe\\OneDrive\\Documents\\EAA skole\\C#\\4.Semester\\Opgave5.3\\data1.csv");
                //people2 = Person.ReadCSVFile("D:\\caspe\\OneDrive\\Documents\\EAA skole\\C#\\4.Semester\\Opgave5.3\\data2.csv");
            }
            catch (Exception e)
            {
                Console.WriteLine("Fejl med indlæsning af liste: " + e.Message);
            }


            //------------------------------------------------------------------------------------
            //Opgave 5.3

            // Find alle personer med score over 2
            List<Person> result = people1.FindAll(p => p.Score < 2);
            Console.WriteLine("Alle med Score over 2: ");
            result.ForEach(p => Console.WriteLine(p));
            result.ForEach(p => counter += 1);
            Console.WriteLine("Antal: " + counter);
            Console.WriteLine();
            Console.WriteLine();

            //Find alle personer med en lige score
            counter = 0;
            List<Person> result2 = people1.FindAll(p => p.Score % 2 == 0);
            Console.WriteLine("Alle med lige Score: ");
            result2.ForEach(p => Console.WriteLine(p));
            result2.ForEach(p => counter += 1);
            Console.WriteLine("Antal: " + counter);
            Console.WriteLine();
            Console.WriteLine();

            //Find alle personer med en lige score og weight over 60
            counter = 0;
            List<Person> result3 = people1.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
            Console.WriteLine("Alle med en lige Score og Weight over 60");
            result3.ForEach(p => Console.WriteLine(p));
            result3.ForEach(p => counter += 1);
            Console.WriteLine("Antal: " + counter);
            Console.WriteLine();
            Console.WriteLine();

            //Find alle personer med en delelig Score med 3
            counter = 0;
            List<Person> result4 = people1.FindAll(p => p.Weight % 3 == 0);
            Console.WriteLine("Alle med en Weight delelig med 3");
            result4.ForEach(p => Console.WriteLine(p));
            result4.ForEach(p => counter += 1);
            Console.WriteLine("Antal: " + counter);
            Console.WriteLine();
            Console.WriteLine();

            //------------------------------------------------------------------------------------
            //Opgave 5.4

            //Find første person med en Score på 3
            Console.WriteLine("Første person med en Score på 3: " + people1.FindIndex(p => p.Score == 3));
            Console.WriteLine();
            Console.WriteLine();

            //Find  index på den første person under 10 år, som har en score på 3
            Console.WriteLine("Index på den første person under 10 år, som har en score på 3: " + people1.FindIndex(p => p.Age < 10 && p.Score == 3));
            Console.WriteLine();
            Console.WriteLine();

            //FInd alle personer under 10 år med en Score på 3
            counter = 0;
            List<Person> result5 = people1.FindAll(p => p.Age < 10 && p.Score == 3);
            Console.WriteLine("Alle under 10 år med en Score på 3");
            result5.ForEach(p => Console.WriteLine(p));
            result5.ForEach(p => counter += 1);
            Console.WriteLine("Antal: " + counter);
            Console.WriteLine();
            Console.WriteLine();

            //Find index på den første person under 8 år, som har en score på 3
            Console.WriteLine("Index på den første person under 8 år, som har en score på 3: " + people1.FindIndex(p => p.Age < 8 && p.Score == 3));
            Console.WriteLine();
            Console.WriteLine();


            //------------------------------------------------------------------------------------
            //Opgave 5.6-7

            //Find alle personer med en Score på 6 og over, samt Age 40 og under
            counter = 0;
            List<Person> result6 = people1.FindAll(p => p.Score >= 6 && p.Age <= 40);
            Console.WriteLine("Alle med en Score på 6 og over, samt Age 40 og under");
            result6.ForEach(p => Console.WriteLine(p));
            result6.ForEach(p => counter += 1);
            Console.WriteLine("Antal: " + counter);
            Console.WriteLine();
            Console.WriteLine();

            //Find alle personer med en Score på 6 og over, samt Age 40 og under
            Console.WriteLine("Test af SetAccepted");
            people1.SetAcceptedP(p => p.Score >= 6 && p.Age <= 40);
            result6.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();
            Console.WriteLine();

            //Sorter listen efter Score og Age med OrderBy descending
            Console.WriteLine("Sort listen efter Score og Age med OrderBy descending");
            List<Person> result7 = people1
                .OrderByDescending(p => p.Score)
                .ThenByDescending(p => p.Age)
                .ToList();
            result7.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();
            Console.WriteLine();
            //Now by ascending
            Console.WriteLine("Sort listen efter Score og Age med OrderBy ascending");
            List<Person> result8 = people1
                .OrderBy(p => p.Score)
                .ThenBy(p => p.Age)
                .ToList();
            result8.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();
            Console.WriteLine();

            //------------------------------------------------------------------------------------
            //Opgave 5.8-9

            //Returner alle two-digit integers sorteret i ascending order
            IEnumerable<int> result9 = numbers
                .Where(i => i.ToString().Length == 2)
                .OrderBy(p => p);
            Console.WriteLine("(Method)Alle tal med to cifre sorteret ascending: ");
            foreach (int i in result9)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Returner alle two-digit integers sorteret i descending order
            IEnumerable<int> result10 = numbers
                .Where(i => i.ToString().Length == 2)
                .OrderByDescending(p => p);
            Console.WriteLine("(Method)Alle tal med to cifre sorteret descending: ");
            foreach (int i in result10)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Returner alle two-digit integers sorteret i ascending order og om de er lige eller ulige
            IEnumerable<string> result11 = numbers
                .Where(i => i.ToString().Length == 2)
                .OrderBy(p => p)
                .Select(p => p % 2 == 0 ? p + " even" : p + " ueven");
            Console.WriteLine("(Method)Alle tal med to cifre sorteret ascending og om de er lige/ulige: ");
            foreach (string i in result11)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Test af Reset til false
            Console.WriteLine("Test af Reset");
            people1.Reset();
            result6.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();
            Console.WriteLine();
            //------------------------------------------------------------------------------------
            //Opgave 5.10

            //Find antal ulige tal i listen randomNumbers
            Console.WriteLine("Antal ulige tal i listen randomNumbers: " + randomNumbers.Count(i => i % 2 != 0));
            Console.WriteLine();
            Console.WriteLine();

            //Find antallet af unikke tal i listen randomNumbers
            Console.WriteLine("Antal unikke tal i listen randomNumbers: " + randomNumbers.Distinct().Count());
            Console.WriteLine();
            Console.WriteLine();

            //Find de tre første ulige tal
            Console.WriteLine("De tre første ulige tal: ");
            foreach (int i in randomNumbers
                .Where(i => i % 2 != 0)
                .Take(3))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Find alle unikke ulige tal i listen randomNumbers
            Console.WriteLine("Alle unikke ulige tal i listen randomNumbers: ");
            foreach (int i in randomNumbers
                .Where(i => i % 2 != 0)
                .Distinct())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();


            //-----------------------------------------------------------------------------------------
            //Opgave 5.11

            //Grupper alle personer i people1 efter det første bogstav i deres navn
            Console.WriteLine("Sorteret efter det første bogstav i deres navn: ");
            var result12 = people1
            .GroupBy(p => p.Name.Substring(0, 1))
            .OrderBy(group => group.Key);

            foreach (var group in result12)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"\t{person.Name}");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------
            //Opgave 5.12

            // Find alle personer med samme navne, som er både i data1.csv og data2.csv via inner join
            var joinPeople = people1
                .Join(people2, p1 => p1.Name, p2 => p2.Name,
                (p1, p2) => new
                {
                    p1.Name,
                    p1.Age,
                    p1.Weight,
                    p1.Accepted
                });

            var joinPeopleResult = joinPeople.GroupBy(jp => jp.Name);
            foreach (var nameGroup in joinPeopleResult)
            {
                Console.WriteLine("The following name is a duplicate: " + nameGroup.Key);
                foreach (var person in nameGroup)
                {
                    Console.WriteLine($"Info on person: Name: {person.Name} Age: {person.Age} Weight: {person.Weight} Accepted: {person.Accepted}");
                    Console.WriteLine();
                }
            }


        }



        static void Main(string[] args)
        {
            GetListOfPeople();

        }
    }
}
