using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Debug.Assert(username != null && username.Length <= 100, "Username tidak boleh null atau lebih dari 100 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null, "Video tidak boleh null");
        Debug.Assert(video.GetPlayCount() < int.MaxValue, "Play count harus kurang dari batas maksimum integer");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount(); // Menggunakan getter
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {username}");
        int count = 0;
        foreach (var video in uploadedVideos)
        {
            if (count == 8) break; // Post-condition: Maksimal print 8 video
            video.PrintVideoDetails();
            count++;
        }
    }
}
