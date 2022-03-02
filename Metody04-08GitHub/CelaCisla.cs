using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08GitHub
{
    class CelaCisla
    {
        public static double Mocnina(int x, int y)
        {
            int mocnina = 1;
            double vysledek = 0;
            if (y < 0)
            {
                for (int i = 0; i < -y; ++i)
                {
                    mocnina *= x;
                }
                vysledek = 1 / (double)mocnina;
                return vysledek;
            }
            else
            {
                for (int i = 0; i < y; ++i)
                {
                    mocnina *= x;
                }
                return mocnina;
            }
        }

        public static int Faktorial(int x)
        {
            int faktorial = 1;
            if (x < 0) throw new ArgumentException("Faktoriál nelze spočítat ze záporného čísla");
            else
            {
                for (int i = 1; i <= x; ++i)
                {
                    faktorial *= i;
                }
                return faktorial;
            }
        }

        public static int CifLichSoucet(int x)
        {
            int CifLichSoucet = 0;
            while (x > 0)
            {
                int cifra = x % 10;
                if (cifra % 2 != 0)
                {
                    CifLichSoucet += cifra;
                }

                x = x / 10;
            }

            return CifLichSoucet;
        }

        public static bool JePrvocislo(int x)
        {
            bool jePrvocislo = x != 1;
            for (int delitel = 2; delitel <= Math.Sqrt(x) && jePrvocislo; ++delitel)
            {
                if (x % delitel == 0) jePrvocislo = false;
            }

            return jePrvocislo;
        }

        public static int PocetSudDelitelu(int x)
        {
            int pocetSudDelitelu = 0;
            for (int i = 1; i <= x; ++i)
            {
                if (x % i == 0)
                {
                    if (i % 2 == 0) ++pocetSudDelitelu;
                }
            }

            return pocetSudDelitelu;
        }
    }
}
