namespace MusicStore.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }

        public Book(string name, double price, string imageUrl, string author, string publisher, short published, string isbn) : base(name, price, imageUrl)
        {
            Author = author;
            Publisher = publisher;
            Published = published;
            ISBN = isbn;
        }
    }
}
