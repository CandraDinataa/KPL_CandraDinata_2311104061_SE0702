using System;
using MatematikaLibraries;

namespace Modul10App
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematika mtk = new Matematika();

            Console.WriteLine("FPB(60, 45) = " + mtk.FPB(60, 45));
            Console.WriteLine("KPK(12, 8) = " + mtk.KPK(12, 8));

            int[] turunanInput = { 1, 4, -12, 9 };
            Console.WriteLine("Turunan dari x^3 + 4x^2 -12x + 9:");
            Console.WriteLine(mtk.Turunan(turunanInput));

            int[] integralInput = { 4, 6, -12, 9 };
            Console.WriteLine("Integral dari 4x^3 + 6x^2 -12x + 9:");
            Console.WriteLine(mtk.Integral(integralInput));
        }
    }
}
