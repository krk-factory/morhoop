using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MorphoOp
{
    class Erozja
    {
        private OurBitmap obrazWe;
        private Bitmap obrazZr;
        private Bitmap obrazWy;

        private ElementStrukt elS;
        
        public Erozja(Bitmap obrazZr, OurBitmap obrazWe, ElementStrukt elS)
        {
            this.obrazWe = obrazWe;
            this.obrazZr = obrazZr;
            this.elS = elS;

            this.obrazWy = new Bitmap(obrazZr.Width, obrazZr.Height);
        }

        public Bitmap wykonajOperacje()
        {
            int[,] strukturaElementu = elS.StrukturaElementu;
            
            for (int k1 = elS.WielkoscElementu; k1 < obrazWe.image.Width-elS.WielkoscElementu; k1++)
            {
                for (int k2 = elS.WielkoscElementu; k2 < obrazWe.image.Height-elS.WielkoscElementu; k2++)
                {
                    int[,] temp_window = clusterImage(k1, k2);
                    obrazWy.SetPixel(k1-elS.WielkoscElementu, k2-elS.WielkoscElementu, findColor(temp_window));
                }
            }

            return obrazWy;
        }

        private Color findColor(int[,] temp_window)
        {
            int[,] maska = elS.StrukturaElementu;
            int min = 255;
            for (int i = 0; i < elS.WielkoscElementuCalkowita; i++)
                for (int j = 0; j < elS.WielkoscElementuCalkowita; j++)
                    if (maska[i, j] != 0)
                        if (temp_window[i, j] < min)
                            min = temp_window[i, j];

            return Color.FromArgb(min, min, min);
        }

        private int[,] clusterImage(int k1, int k2)
        {
            int[,] temp_image = new int[elS.WielkoscElementuCalkowita, elS.WielkoscElementuCalkowita];

            int licznik1 = 0;
            int licznik2;

            for (int i = k1 - elS.WielkoscElementu; i <= k1 + elS.WielkoscElementu; i++)
            {
                licznik2 = 0;
                for (int j = k2 - elS.WielkoscElementu; j <= k2 + elS.WielkoscElementu; j++)
                    temp_image[licznik1, licznik2++] = obrazWe.image.GetPixel(i, j).R;
                licznik1++;
            }
            
            return temp_image;
        }
    }
}
