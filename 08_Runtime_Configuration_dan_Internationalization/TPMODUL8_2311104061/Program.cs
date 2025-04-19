using System.Text.Json;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config;
        string filePath = "covid_config.json";

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<CovidConfig>(json);
        }
        else
        {
            config = new CovidConfig();
        }

        // Input suhu dalam Celcius
        Console.Write("Berapa suhu badan anda saat ini? Dalam nilai celcius: ");
        double suhuCelcius = Convert.ToDouble(Console.ReadLine());

        // Konversi ke Fahrenheit
        double suhuFahrenheit = (suhuCelcius * 9 / 5) + 32;
        Console.WriteLine($"Suhu badan dalam Fahrenheit: {suhuFahrenheit}");

        // Input hari demam
        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hariDemam = Convert.ToInt32(Console.ReadLine());

        // Set satuan ke Fahrenheit untuk validasi
        config.satuan_suhu = "fahrenheit";

        bool suhuNormal = suhuFahrenheit >= 97.7 && suhuFahrenheit <= 99.5;
        bool hariDemamNormal = hariDemam < config.batas_hari_deman;

        Console.WriteLine((suhuNormal && hariDemamNormal) ? config.pesan_diterima : config.pesan_ditolak);
    }
}
