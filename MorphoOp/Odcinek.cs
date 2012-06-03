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

            strukturaElementu = new int[2 * wielkoscElementu + 1, 2 * wielkoscElementu + 1];

            // Bo nie istnieje tg(90)
            if (nachylenie == 90)
            {
                wypelnijStrukture90();
            }
            // Dla pozostałych wielkości nachylenia
            else
            {
                wypelnijStrukture();
            }
        }

        private void wypelnijStrukture()
        {
            // k1, k2 --> chodzenie po tablicy
            // x, y --> argument, wartość --> w tablicy "środek układu współrzędnych" jest w punkcie (wielkoscElementu, wielkoscElementu)
            for (int k2 = 2 * wielkoscElementu, y = -1 * wielkoscElementu; k2 >= 0; k2--, y++)
            {
                for (int k1 = 0, x = -1 * wielkoscElementu; k1 < 2 * wielkoscElementu + 1; k1++, x++)
                {
                    if (y == Math.Round(Math.Tan(nachylenieOdcinka * (Math.PI / 180)) * x))        // Tangens musi być w radianach
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

        private void wypelnijStrukture90()
        {
            for (int k1 = 0; k1 < 2 * wielkoscElementu + 1; k1++)
            {
                strukturaElementu[wielkoscElementu, k1] = 1;
            }
        }
    }
}
