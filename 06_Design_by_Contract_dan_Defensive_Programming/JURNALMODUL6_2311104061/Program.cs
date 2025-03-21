using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Candra Dinata");

        string[] judulFilm = {
            "Review Film Your Name",
            "Review Film Spirited Away",
            "Review Film A Silent Voice",
            "Review Film Weathering With You",
            "Review Film Howl's Moving Castle",
            "Review Film Grave of the Fireflies",
            "Review Film My Neighbor Totoro",
            "Review Film One Piece Film: Red",
            "Review Film The Wind Rises",
            "Review Film Jujutsu Kaisen"
        };

        foreach (string judul in judulFilm)
        {
            SayaTubeVideo video = new SayaTubeVideo(judul);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}
