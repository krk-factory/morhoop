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

            // TO DO !!!
            // Aby zachować integralność z pozostałymi elementami, odcinek musi mieć długość 2 * n + 1
        }
    }
}
