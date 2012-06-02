using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MorphoOp
{
    class GradientMorfoErozja : GradientMorfo
    {
        public GradientMorfoErozja(Bitmap obrazZr, OurBitmap obrazWe, ElementStrukt elS)
        {
            this.obrazWe = obrazWe;
            this.obrazZr = obrazZr;
            this.elS = elS;
        }

        override public Bitmap wykonajOperacje()
        {
            Erozja er = new Erozja(obrazZr, obrazWe, elS);

            return odejmowanieBitmap(obrazZr, er.wykonajOperacje());
        }
    }
}
