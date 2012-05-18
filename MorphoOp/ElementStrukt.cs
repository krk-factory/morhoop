using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorphoOp
{
    class ElementStrukt
    {
        private int[,] strukturaElementu;

        public ElementStrukt() {}

        public ElementStrukt(string typEl, int wielkosc)
        {
            if (typEl == "kwadrat")       
            {
                strukturaElementu = new int[wielkosc, wielkosc];

                for (int k1 = 0; k1 < wielkosc; k1++)
                {
                    for (int k2 = 0; k2 < wielkosc; k2++)
                    {
                        strukturaElementu[k1, k2] = 1;
                    }
                }
            }
            else if (typEl == "kolo")       // w tym przypadku 'wielkosc' to promien
            {
                int srednica = 2 * wielkosc + 1;
                int srodek = (srednica + 1) / 2;

                strukturaElementu = new int[srednica, srednica];

                for (int k1 = 0; k1 < srednica; k1++)
                {
                    for (int k2 = 0; k2 < srednica; k2++)
                    {
                        if (Math.Pow((k1 - srodek), 2) + Math.Pow((k2 - srodek), 2) <= Math.Pow(wielkosc, 2))
                        {
                            strukturaElementu[k1, k2] = 1;
                        }
                        else
                        {
                            strukturaElementu[k1, k2] = 9;     // 9 - dowolony element
                        }
                    }
                }
            }
            else
            {
                // TODO
            }
        }
    }
}
