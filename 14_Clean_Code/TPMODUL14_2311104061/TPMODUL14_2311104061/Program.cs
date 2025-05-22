using System;

/// <summary>
/// Program utama untuk menjalankan aplikasi SayaTubeVideo
/// </summary>
internal class Program
{
    private static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Candra Dinata]");

        try
        {
            for (int i = 0; i < 100; i++)
            {
                video.IncreasePlayCount(100_000);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        video.PrintVideoDetails();
    }
}
