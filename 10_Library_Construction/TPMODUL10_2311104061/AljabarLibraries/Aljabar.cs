using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        // Fungsi untuk mencari akar-akar dari persamaan kuadrat ax^2 + bx + c = 0
        public static double[] AkarPersamaanKuadrat(double[] koef)
        {
            double a = koef[0];
            double b = koef[1];
            double c = koef[2];

            double diskriminan = b * b - 4 * a * c;
            double akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);

            return new double[] { akar1, akar2 };
        }

        // Fungsi untuk mengkuadratkan bentuk (ax + b)^2 menjadi [a^2, 2ab, b^2]
        public static double[] HasilKuadrat(double[] linear)
        {
            double a = linear[0];
            double b = linear[1];

            double a2 = a * a;
            double ab2 = 2 * a * b; // Term ini akan menjadi negatif jika b negatif
            double b2 = b * b;

            return new double[] { a2, ab2, b2 };
        }
    }
}
