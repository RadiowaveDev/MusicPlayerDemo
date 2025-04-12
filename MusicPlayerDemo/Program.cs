namespace MusicPlayerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Bohemian Rapsody","Another one bites the dust","Queen song","Rock");
            song1.Album="Fat bottom girl";
            Console.WriteLine(song1.Album);

        }
    }
}
