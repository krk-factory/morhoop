using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MorphoOp
{
    abstract class GradientMorfo
    {
        protected OurBitmap obrazWe;
        protected Bitmap obrazZr;

        protected ElementStrukt elS;

        abstract public Bitmap wykonajOperacje();

        /* --- Bitmap jest sealed class, więc inaczej się nie da - jeśli się da, to trzeba nieźle się nakombinować ---*/
        virtual protected Bitmap odejmowanieBitmap(Bitmap bmp1, Bitmap bmp2)
        {
            Bitmap tmp = new Bitmap(bmp1.Width, bmp1.Height);
            int t;

            for (int k1 = 0; k1 < bmp1.Width; k1++)     // Przy uwzględnieniu, że mamy te same wymiary - do naszych potrzeb więcej nic nie trzeba
            {
                for (int k2 = 0; k2 < bmp1.Height; k2++)
                {
                    t = bmp1.GetPixel(k1, k2).R - bmp2.GetPixel(k1, k2).R;

                    if (t < 0)
                        t = 0;
                    else if (t > 255)
                        t = 255;

                    tmp.SetPixel(k1, k2, Color.FromArgb(t, t, t));
                }
            }

            return tmp;
        } 
    }
}
