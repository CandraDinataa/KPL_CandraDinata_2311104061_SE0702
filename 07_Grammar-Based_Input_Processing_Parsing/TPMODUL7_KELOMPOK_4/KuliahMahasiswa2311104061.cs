using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class KuliahMahasiswa2311104061
{
    [JsonPropertyName("mata_kuliah")]
    public List<MataKuliah> mata_kuliah { get; set; }

    public class MataKuliah
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("tp7_2_2311104061.json");
        var data = JsonSerializer.Deserialize<KuliahMahasiswa2311104061>(json);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var mk in data.mata_kuliah)
        {
            Console.WriteLine($"MK {i} {mk.Code} - {mk.Name}");
            i++;
        }
    }
}
