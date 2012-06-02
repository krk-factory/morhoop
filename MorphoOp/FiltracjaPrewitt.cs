using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MorphoOp
{
    class FiltracjaPrewitt
    {
        private OurBitmap obrazWe;
        private Bitmap obrazZr;

        private const int maskSize = 3;

        private int[,] PrewittMaskVertical;
        private int[,] PrewittMaskHorizontal;

        public FiltracjaPrewitt(Bitmap obrazZr, OurBitmap obrazWe)
        {
            PrewittMaskHorizontal = new int[,] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            PrewittMaskVertical = new int[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };

            this.obrazWe = obrazWe;
            this.obrazZr = obrazZr;
        }

        public Bitmap wykonajOperacje()
        {
            Bitmap obrazWy = new Bitmap(obrazZr.Width, obrazZr.Height);

            for (int m = maskSize; m < obrazWe.image.Width - maskSize; m++)
                for (int n = maskSize; n < obrazWe.image.Height - maskSize; n++)
                {
                    int color_h = 0;
                    for (int j = 0; j < maskSize; j++)
                        for (int k = 0; k < maskSize; k++)
                            color_h += PrewittMaskHorizontal[j, k] * obrazWe.image.GetPixel(m - j, n - k).R;

                    int color_v = 0;
                    for (int j = 0; j < maskSize; j++)
                        for (int k = 0; k < maskSize; k++)
                            color_v += PrewittMaskVertical[j, k] * obrazWe.image.GetPixel(m - j, n - k).R;

                    int color = (int)Math.Sqrt(Math.Pow(color_h, 2) + Math.Pow(color_v, 2));
                    //int color = color_h;
                    if (color > 255) color = 255;
                    else if (color < 0) color = 0;
                    Color final_color = Color.FromArgb(color, color, color);

                    obrazWy.SetPixel(m-maskSize, n-maskSize, final_color);
                }
            return obrazWy;
        }
    }
}