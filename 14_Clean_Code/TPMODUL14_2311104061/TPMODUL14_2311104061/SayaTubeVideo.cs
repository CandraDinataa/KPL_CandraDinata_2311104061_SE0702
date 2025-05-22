using System;
using System.Diagnostics;

/// <summary>
/// Kelas untuk merepresentasikan video di SayaTube
/// </summary>
public class SayaTubeVideo
{
    private int _id;
    private string _title;
    private int _playCount;

    /// <summary>
    /// Konstruktor untuk menginisialisasi objek video
    /// </summary>
    /// <param name="title">Judul video</param>
    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100,
            "Judul video tidak boleh kosong dan maksimal 100 karakter.");

        Random random = new Random();
        _id = random.Next(10000, 99999);
        _title = title;
        _playCount = 0;
    }

    /// <summary>
    /// Menambah jumlah play count video
    /// </summary>
    /// <param name="count">Jumlah penambahan</param>
    public void IncreasePlayCount(int count)
    {
        if (count <= 0 || count > 10_000_000)
        {
            throw new ArgumentException("Input play count harus antara 1 hingga 10.000.000.");
        }

        try
        {
            checked
            {
                _playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("ERROR: Play count melebihi batas integer.");
        }
    }

    /// <summary>
    /// Menampilkan detail video
    /// </summary>
    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Play Count: {_playCount}");
    }
}
