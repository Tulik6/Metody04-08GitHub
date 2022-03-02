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
    }
}
