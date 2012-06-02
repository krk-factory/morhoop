using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorphoOp
{
    class Odcinek : ElementStrukt
    {
        /* --- Konstruktor --- */

        public Odcinek(int dlugosc, int nachylenie)
        {
            nazwaElementu = "Odcinek";
            wielkoscElementu = dlugosc;        // Długość
            nachylenieOdcinka = nachylenie;    // Nachylenie
            wielkoscElementuCalkowita = 2 * dlugosc + 1;

            // TO DO !!!
            // Aby zachować integralność z pozostałymi elementami, odcinek musi mieć długość 2 * n + 1

            strukturaElementu = new int[2 * wielkoscElementu + 1, 2 * wielkoscElementu + 1];

            for (int k1 = 0; k1 < 2 * wielkoscElementu + 1; k1++)
            {
                for (int k2 = 0; k2 < 2 * wielkoscElementu + 1; k2++)
                {
                    if (k1 == Math.Floor(Math.Tan(nachylenie * (Math.PI/180)) * k2))        // Tangens musi być w radianach
                    {                                                                       // Próby korzystania z zależności y = tg(a) * x + b
                        strukturaElementu[k1, k2] = 1;
                    }
                    else
                    {
                        strukturaElementu[k1, k2] = 0;     // 0 - dowolony element
                    }
                }
            }
        }
    }
}
