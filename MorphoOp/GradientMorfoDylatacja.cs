using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MorphoOp
{
    class GradientMorfoDylatacja : GradientMorfo
    {
        public GradientMorfoDylatacja(Bitmap obrazZr, OurBitmap obrazWe, ElementStrukt elS)
        {
            this.obrazWe = obrazWe;
            this.obrazZr = obrazZr;
            this.elS = elS;
        }

        override public Bitmap wykonajOperacje()
        {
            Dylatacja er = new Dylatacja(obrazZr, obrazWe, elS);

            return odejmowanieBitmap(er.wykonajOperacje(), obrazZr);
        }
    }
}
