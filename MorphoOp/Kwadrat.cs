using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorphoOp
{
    class Kwadrat : ElementStrukt
    {
        /* --- Konstruktor --- */
        
        public Kwadrat(int bok)     // Aby mieć kwadrat jako ES musi mieć on bok o niepatrzystej wielkości określającej jego długość
        {
            nazwaElementu = "Kwadrat";
            wielkoscElementu = bok;
            wielkoscElementuCalkowita = 2 * bok + 1;

            strukturaElementu = new int[2 * wielkoscElementu + 1, 2 * wielkoscElementu + 1];

            for (int k1 = 0; k1 < 2 * wielkoscElementu + 1; k1++)
            {
                for (int k2 = 0; k2 < 2 * wielkoscElementu + 1; k2++)
                {
                    strukturaElementu[k1, k2] = 1;
                }
            }
        }
    }
}
