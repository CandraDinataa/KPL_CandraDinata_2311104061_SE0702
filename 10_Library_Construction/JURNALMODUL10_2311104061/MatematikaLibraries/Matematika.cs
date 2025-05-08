using System;
using System.Collections.Generic;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return a * b / FPB(a, b);
        }

        public string Turunan(int[] koefisien)
        {
            List<string> hasil = new List<string>();
            int derajat = koefisien.Length - 1;
            for (int i = 0; i < koefisien.Length - 1; i++)
            {
                int coef = koefisien[i] * (derajat - i);
                if (coef == 0) continue;

                string suku = coef.ToString();
                if (derajat - i - 1 > 0)
                {
                    suku += "x";
                    if (derajat - i - 1 > 1)
                        suku += (derajat - i - 1).ToString();
                }
                hasil.Add(suku);
            }
            return string.Join(" + ", hasil).Replace("+ -", "- ");
        }

        public string Integral(int[] koefisien)
        {
            List<string> hasil = new List<string>();
            int derajat = koefisien.Length - 1;

            for (int i = 0; i < koefisien.Length; i++)
            {
                int pangkatBaru = derajat - i + 1;
                double nilai = (double)koefisien[i] / pangkatBaru;

                if (nilai == 0) continue;

                string suku = "";
                if (nilai == 1)
                    suku = "";
                else if (nilai == -1)
                    suku = "-";
                else
                    suku = nilai % 1 == 0 ? ((int)nilai).ToString() : nilai.ToString("0.##");

                suku += "x";
                if (pangkatBaru > 1)
                    suku += pangkatBaru.ToString();

                hasil.Add(suku);
            }

            hasil.Add("C");
            return string.Join(" + ", hasil).Replace("+ -", "- ");
        }
    }
}
