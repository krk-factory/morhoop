using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorphoOp
{
    class Kwadrat : ElementStrukt
    {
        /* --- Konstruktor --- */
        
        public Kwadrat(int bok)
        {
            nazwaElementu = "Kwadrat";
            wielkoscElementu = bok;

            strukturaElementu = new int[wielkoscElementu, wielkoscElementu];

            for (int k1 = 0; k1 < wielkoscElementu; k1++)
            {
                for (int k2 = 0; k2 < wielkoscElementu; k2++)
                {
                    strukturaElementu[k1, k2] = 1;
                }
            }
        }
    }
}
