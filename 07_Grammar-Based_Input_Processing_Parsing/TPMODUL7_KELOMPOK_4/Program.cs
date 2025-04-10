using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== JSON 1 ===");
        DataMahasiswa2311104061.ReadJSON();

        Console.WriteLine("\n=== JSON 2 ===");
        KuliahMahasiswa2311104061.ReadJSON();

        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();
    }
}
