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
            // Aby zachować integralność z pozostałymi elementami, odcinek musi być w "oknie" o długości 2 * n + 1

            strukturaElementu = new int[2 * wielkoscElementu + 1, 2 * wielkoscElementu + 1];

            int tmp1 = 0;

            //for (int k1 = 0; k1 < 2 * wielkoscElementu + 1; k1++)
            for (int y = 2 * wielkoscElementu, yw = -1 * wielkoscElementu; y >= 0; y--, yw++)
            {
                //for (int k2 = 0; k2 < 2 * wielkoscElementu + 1; k2++)
                for (int x = 0, xw = -1 * wielkoscElementu; x < 2 * wielkoscElementu + 1; x++, xw++)
                {
                    if (yw == Math.Round(Math.Tan(nachylenie * (Math.PI/180)) * xw))        // Tangens musi być w radianach
                    {                                                                       // Próby korzystania z zależności y = tg(a) * x + b
                        strukturaElementu[x, y] = 1;
                    }
                    else
                    {
                        strukturaElementu[x, y] = 0;     // 0 - dowolony element
                    }
                }

                tmp1++;
            }
        }
    }
}
