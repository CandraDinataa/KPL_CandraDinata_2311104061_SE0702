using System;
using AljabarLibraries;

namespace AljabarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contoh input untuk persamaan kuadrat x^2 - 3x - 10
            double[] kuadrat = { 1, -3, -10 };
            double[] akar = Aljabar.AkarPersamaanKuadrat(kuadrat);
            Console.WriteLine("Akar Persamaan Kuadrat dari (1, -3, -10):");
      
            Console.WriteLine($"x1 = {akar[0]}");
            Console.WriteLine($"x2 = {akar[1]}");

            // Contoh input untuk (2x - 3)^2
            double[] linear = { 2, -3 };
            double[] hasilKuadrat = Aljabar.HasilKuadrat(linear);
            Console.WriteLine("\nHasil kuadrat dari (2x - 3):");
            Console.WriteLine($"{hasilKuadrat[0]}, {hasilKuadrat[1]}, {hasilKuadrat[2]}");
        }
    }
}
