using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Candra Dinata");

        (string judul, int playCount)[] daftarFilm = {
            ("Review Film Your Name", 5000000),
            ("Review Film Spirited Away", 7200000),
            ("Review Film A Silent Voice", 4300000),
            ("Review Film Weathering With You", 6100000),
            ("Review Film Howl's Moving Castle", 5500000),
            ("Review Film Grave of the Fireflies", 3800000),
            ("Review Film My Neighbor Totoro", 5900000),
            ("Review Film One Piece Film: Red", 8200000),
            ("Review Film The Wind Rises", 4700000),
            ("Review Film Jujutsu Kaisen", 7600000)
        };

        foreach (var film in daftarFilm)
        {
            SayaTubeVideo video = new SayaTubeVideo(film.judul);
            video.IncreasePlayCount(film.playCount);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();

        // Testing IncreasePlayCount
        Console.WriteLine("\nTesting IncreasePlayCount...");
        SayaTubeVideo testVideo = new SayaTubeVideo("Test Video");
        testVideo.IncreasePlayCount(10000000);
        testVideo.PrintVideoDetails();

        // Testing Overflow
        Console.WriteLine("\nTesting Overflow...");
        try
        {
            testVideo.IncreasePlayCount(int.MaxValue);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }
}
