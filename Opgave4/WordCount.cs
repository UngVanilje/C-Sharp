namespace Opgave4
{
    public static class WordCount
    {

        internal static int WordCounter(this string str)
        {
            String[] word = str.Split(new char[] { ' ' });

            if (word.Length <= 5)
                throw new ArgumentException("String is too short");
            else
                return word.Length;
        }

        public static string ExtractWord(this string str, int n)
        {
            String[] word = str.Split(new char[] { ' ' });

            if (n < 0 || word.Length <= n)
                throw new ArgumentOutOfRangeException("Wordindex out of bounds");
            else
                return word[n];
        }
        static void Main(string[] args)
        {
            string str = "Jesus christ it is jason bourne";
            int n = str.WordCounter();
            Console.WriteLine("Number of words:" + n);
            Console.WriteLine(ExtractWord(str, 5));
        }
    }

}

