namespace Opgave4._6
{
    internal class ByAgeSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
