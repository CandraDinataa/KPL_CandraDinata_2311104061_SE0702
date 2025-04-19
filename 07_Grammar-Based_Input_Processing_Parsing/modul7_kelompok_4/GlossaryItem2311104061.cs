using System;
using System.IO;
using System.Text.Json;

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public string Title { get; set; }
    public string GlossSee { get; set; }
}

public class GlossList
{
    public GlossEntry GlossEntry { get; set; }
}

public class GlossDiv
{
    public GlossList GlossList { get; set; }
}

public class GlossRoot
{
    public GlossDiv GlossDiv { get; set; }
}

public class GlossaryItem2311104061
{
    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_3_2311104061.json");
        GlossRoot root = JsonSerializer.Deserialize<GlossRoot>(json);
        GlossEntry entry = root.GlossDiv.GlossList.GlossEntry;

        Console.WriteLine("GlossEntry:");
        Console.WriteLine($"ID        : {entry.ID}");
        Console.WriteLine($"SortAs    : {entry.SortAs}");
        Console.WriteLine($"GlossTerm : {entry.GlossTerm}");
        Console.WriteLine($"Acronym   : {entry.Acronym}");
        Console.WriteLine($"Abbrev    : {entry.Abbrev}");
        Console.WriteLine($"Title     : {entry.Title}");
        Console.WriteLine($"GlossSee  : {entry.GlossSee}");
    }
}
