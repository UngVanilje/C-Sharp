namespace Opgave3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Medarbejder> medarbejdere = new();
            var medarbejderCollection = new MedarbejderListe<object>();

            cprNr c1 = new("1996", "123456-7891");
            cprNr c2 = new("1997", "123456-7871");
            cprNr c3 = new("1997", "123456-7881");
            cprNr c4 = new("1998", "123456-7861");

            Adresse a1 = new("PcGangsgersvej", 69);
            Adresse a2 = new("Celinegwionsvej", 1);
            Adresse a3 = new("Mongovej", 66);
            Adresse a4 = new("Guffeluffesvej", 69);
            Adresse a5 = new("Cocklordsvej", 666);
            Adresse a6 = new("Bobsvej", 44);

            Firma f1 = new("IBM", a5);
            Firma f2 = new("Microsoft", a6);

            Mekaniker m1 = new("Bokki", a1, c1, 1996, 300);
            Mekaniker m2 = new("Gewir", a2, c2, 1997, 200);
            Synsmand s1 = new("Krølle", a3, c3, 1997, 200, 10, 290);
            Værkfører v1 = new("Fætter Guf", a4, c4, 1998, 100, 2014, 1000);

            Console.WriteLine("Test af normal liste");
            medarbejdere.Add(m1);
            medarbejdere.Add(m2);
            medarbejdere.Add(s1);
            medarbejdere.Add(v1);

            foreach (Medarbejder m in medarbejdere)
            {
                Console.WriteLine(m.ToString());
            }

            Console.WriteLine("Test af dictionary");
            medarbejderCollection.AddElement(c1, m1);
            medarbejderCollection.AddElement(c2, m2);
            medarbejderCollection.AddElement(c3, s1);
            medarbejderCollection.AddElement(c4, v1);
            medarbejderCollection.AddElement(f1.Adresse, f1);
            medarbejderCollection.AddElement(f2.Adresse, f2);

            Console.WriteLine("Size of current dictionary: " + medarbejderCollection.size());
            medarbejderCollection.Print();


        }
    }
}
