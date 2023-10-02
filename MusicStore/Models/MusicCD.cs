namespace MusicStore.Models
{
    public class MusicCD : Product
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public List<string> Tracks { get; }

        public MusicCD(string name, double price, string imageUrl, string artist, string label, short released, List<string> tracks) : base(name, price, imageUrl)
        {
            Artist = artist;
            Label = label;
            Released = released;
            Tracks = tracks;
        }

        public void AddTrack(string track)
        {
            Tracks.Add(track);
        }
    }
}
