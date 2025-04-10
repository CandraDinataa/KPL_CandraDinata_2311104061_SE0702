using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa2311104061
{
    public string nama_depan { get; set; }
    public string nama_belakang { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("tp7_1_2311104061.json");
        var data = JsonSerializer.Deserialize<DataMahasiswa2311104061>(json);
        Console.WriteLine($"Nama {data.nama_depan} {data.nama_belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}
