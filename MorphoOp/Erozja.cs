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

        
        public Erozja(Bitmap obraz, ElementStrukt elS)
        {
            this.obrazWe = obraz;
            this.elS = elS;

            //wielkoscGranic = elS.WielkoscElementu;
        }

        public Bitmap zasadniczaErozja()
        {
            inicjalizacjaObrazu(elS.WielkoscElementu);

            return obrazWe;
        }
        
        private void inicjalizacjaObrazu(int wielkoscElementu)
        {
            
        }


    }
}
