using System;
using System.Diagnostics;

/// <summary>
/// Represents a video on SayaTube
/// </summary>
public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    /// <summary>
    /// Initializes a new instance of the <see cref="SayaTubeVideo"/> class with a specified title.
    /// </summary>
    /// <param name="title">The title of the video.</param>
    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100,
            "Title must not be empty and must be at most 100 characters.");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    /// <summary>
    /// Increases the play count of the video.
    /// </summary>
    /// <param name="count">Number of plays to add (1 - 10,000,000).</param>
    public void IncreasePlayCount(int count)
    {
        if (count <= 0 || count > 10_000_000)
        {
            throw new ArgumentException("Play count increment must be between 1 and 10,000,000.");
        }

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("ERROR: Play count exceeded the maximum value of int.");
        }
    }

    /// <summary>
    /// Prints the video details to the console.
    /// </summary>
    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {this.id}");
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Play Count: {this.playCount}");
    }
}
