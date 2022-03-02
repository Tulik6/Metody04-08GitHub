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
    }
}
