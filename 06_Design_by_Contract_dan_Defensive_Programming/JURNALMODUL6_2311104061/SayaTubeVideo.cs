using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null && title.Length <= 200, "Judul video tidak boleh null atau lebih dari 200 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count <= 0 || count > 25000000)
        {
            throw new ArgumentException("Play count harus antara 1 - 25.000.000");
        }

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas integer!");
        }
    }


    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    // Getter untuk mengakses title dan playCount
    public string GetTitle()
    {
        return title;
    }

    public int GetPlayCount()
    {
        return playCount;
    }
}
