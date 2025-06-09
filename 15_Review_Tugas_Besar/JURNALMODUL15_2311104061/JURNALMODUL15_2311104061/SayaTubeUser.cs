using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        if (string.IsNullOrEmpty(username) || username.Length > 100)
            throw new ArgumentException("Username tidak valid");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
            throw new ArgumentNullException(nameof(video));

        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"\nUser: {username}");
        Console.WriteLine("Daftar Video:");
        int count = 0;
        foreach (var video in uploadedVideos)
        {
            if (count == 8) break;
            video.PrintVideoDetails();
            count++;
        }
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
            total += video.GetPlayCount();
        return total;
    }
}
