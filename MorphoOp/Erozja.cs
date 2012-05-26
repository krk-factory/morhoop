using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MorphoOp
{
    class Erozja
    {
        private Bitmap obrazWe;
        private Bitmap obrazWy;

        private ElementStrukt elS;

        private int[,] strukturaElementu;

        private int[,][,] tablicaErozyjna;

        
        public Erozja(Bitmap obraz, ElementStrukt elS)
        {
            this.obrazWe = obraz;
            this.elS = elS;
            this.strukturaElementu = elS.StrukturaElementu;

            //wielkoscGranic = elS.WielkoscElementu;
        }

        public Bitmap zasadniczaErozja()
        {
            //inicjalizacjaObrazu(elS.WielkoscElementu);

            return obrazWe;
        }
        
        private void inicjalizacjaTablicy(int wielkoscElementu, int szerokoscObrazka, int wysokoscObrazka)
        {
            tablicaErozyjna = new int[wysokoscObrazka, szerokoscObrazka][,];

            for (int k1 = 0; k1 < wysokoscObrazka; k1++)
            {
                for (int k2 = 0; k2 < szerokoscObrazka; k2++)
                {
                    tablicaErozyjna[k1, k2] = new int[wielkoscElementu, wielkoscElementu];
                }
            }
        }


    }
}
