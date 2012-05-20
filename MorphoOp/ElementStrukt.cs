using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorphoOp
{
    class ElementStrukt
    {
        /* --- Pola klasy --- */
        
        private int[,] strukturaElementu;
        
        private string nazwaElementu;
        private int wielkoscElementu1;  // Długość boku lub promienia
        private int wielkoscElementu2;  // Nachylenie - tylko dla _odcinka_


        /* --- Konstruktory --- */
        
        public ElementStrukt() {}

        public ElementStrukt(string typEl, params int[] wielkosc)
        {
            if (typEl == "kwadrat")     // Jeden element w 'wielkosc', bo mamy tylko bok kwadratu
            {
                nazwaElementu = "Kwadrat";
                wielkoscElementu1 = wielkosc[0];
                
                strukturaElementu = new int[wielkosc[0], wielkosc[0]];

                for (int k1 = 0; k1 < wielkosc[0]; k1++)
                {
                    for (int k2 = 0; k2 < wielkosc[0]; k2++)
                    {
                        strukturaElementu[k1, k2] = 1;
                    }
                }
            }
            else if (typEl == "kolo")      // Jeden element w 'wielkosc', bo mamy tylko promień koła 
                                           // w tym przypadku 'wielkosc[0]' to promien
            {
                nazwaElementu = "Kolo";
                wielkoscElementu1 = wielkosc[0];
                
                int srednica = 2 * wielkosc[0] + 1;
                int srodek = (srednica + 1) / 2;

                strukturaElementu = new int[srednica, srednica];

                for (int k1 = 0; k1 < srednica; k1++)
                {
                    for (int k2 = 0; k2 < srednica; k2++)
                    {
                        if (Math.Pow((k1 - srodek), 2) + Math.Pow((k2 - srodek), 2) <= Math.Pow(wielkosc[0], 2))
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
            else if (typEl == "odcinek")    // Dwa elementy w 'wielkosci' -> [0] - długość, [1] - nachylenie
            {
                nazwaElementu = "Odicnek";
                wielkoscElementu1 = wielkosc[0];    // Długość
                wielkoscElementu2 = wielkosc[1];    // Nachylenie
                
            }
        }


        /* --- Właściwości --- */

        public string NazwaElementu
        {
            get { return nazwaElementu; }
        }

        public int PromienLubBok
        {
            get { return wielkoscElementu1; }
        }

        public int Nachylenie
        {
            get { return wielkoscElementu2; }
        }
    }
}
