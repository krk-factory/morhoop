using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorphoOp
{
    class Kolo : ElementStrukt
    {
        /* --- Konstruktory --- */
        
        public Kolo(int promien)
        {
            nazwaElementu = "Kolo";
            wielkoscElementu = promien;

            int srednica = 2 * wielkoscElementu + 1;
            int srodek = (srednica + 1) / 2;

            strukturaElementu = new int[srednica, srednica];

            for (int k1 = 0; k1 < srednica; k1++)
            {
                for (int k2 = 0; k2 < srednica; k2++)
                {
                    if (Math.Pow((k1 - srodek), 2) + Math.Pow((k2 - srodek), 2) <= Math.Pow(wielkoscElementu, 2))
                    {
                        strukturaElementu[k1, k2] = 255;
                    }
                    else
                    {
                        strukturaElementu[k1, k2] = 999;     // 999 - dowolony element
                    }
                }
            }
        }
    }
}
