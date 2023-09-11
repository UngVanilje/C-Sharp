namespace ConsoleApp1
{
    internal class FileName
    {
        internal static int WordCounter(this string str)
        {
            String[] word = str.Split(new char[] { ' ' });
            return word.Length;
        }
    }
}
