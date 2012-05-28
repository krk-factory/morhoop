﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MorphoOp
{
    class Erozja
    {
        private Bitmap obrazWe;
        private Bitmap obrazZr;
        private Bitmap obrazWy;

        private ElementStrukt elS;

        private int[,] strukturaElementu;
        private int[,][,] tablicaErozyjna;

        int wielkoscElementuCalkowita;
        int wysokoscObrazkaPierwotnego;
        int szerokoscObrazkaPierwotnego;
        
        public Erozja(Bitmap obrazZr, Bitmap obrazWe, ElementStrukt elS)
        {
            this.obrazWe = obrazWe;
            this.obrazZr = obrazZr;
            this.elS = elS;
            this.strukturaElementu = elS.StrukturaElementu;

            this.wielkoscElementuCalkowita = 2 * elS.WielkoscElementu + 1;

            this.wysokoscObrazkaPierwotnego = obrazWe.Height - 2 * elS.WielkoscElementu;
            this.szerokoscObrazkaPierwotnego = obrazWe.Width - 2 * elS.WielkoscElementu;

            this.obrazWy = new Bitmap(szerokoscObrazkaPierwotnego, wysokoscObrazkaPierwotnego);

            inicjalizacjaTablicy(elS.WielkoscElementu, szerokoscObrazkaPierwotnego, wysokoscObrazkaPierwotnego);
        }

        public Bitmap wykonajOperacje()
        {
            wyznaczanieTablicErozyjnych(elS.WielkoscElementu, obrazWe.Width, obrazWe.Height);
            erodowanieZasadnicze(elS.WielkoscElementu, obrazWe.Width, obrazWe.Height);

            return obrazWy;
        }


        /*   Utworzenie macierzy wielkości obrazu źródłowego, której komórki są znów macierzami, 
         *   utworzonymi tak, aby mogły być porównywane bezpośrednio z elementem strukturalnym.
         */
        private void wyznaczanieTablicErozyjnych(int wielkoscElementu, int szerokoscObrazka, int wysokoscObrazka)
        {           
            for (int k1 = 0; k1 < szerokoscObrazkaPierwotnego - 1; k1++)
            {
                for (int k2 = 0; k2 < wysokoscObrazkaPierwotnego - 1; k2++)
                {
                    for (int k3 = 0; k3 < wielkoscElementuCalkowita; k3++)
                    {
                        for (int k4 = 0; k4 < wielkoscElementuCalkowita; k4++)
                        {
                            tablicaErozyjna[k1, k2][k3, k4] = obrazWe.GetPixel(k1 - k3 + wielkoscElementuCalkowita - 1, k2 - k4 + wielkoscElementuCalkowita - 1).R;
                        }
                    }
                }
            } 
        }

        /*  Porównanie komórek tablicaErozyjna[k1][k2] z elemenetem strukturalnym. 
         *  W przypadku zgodności punkt obrazu źródłowego pozostaje bez zmian, 
         *  w przeciwnym wypadku punkt przyjmuje wartość 0.
         */

        private void erodowanieZasadnicze(int wielkoscElementu, int szerokoscObrazka, int wysokoscObrazka)
        {
            int[,] strukturaElementu = elS.StrukturaElementu;

            bool czyIstniejePunkt = true;
            int t;

            
            for (int k1 = 0; k1 < szerokoscObrazkaPierwotnego; k1++)
            {
                for (int k2 = 0; k2 < wysokoscObrazkaPierwotnego; k2++)
                {
                    for (int k3 = 0; k3 < wielkoscElementuCalkowita; k3++)
                    {
                        for (int k4 = 0; k4 < wielkoscElementuCalkowita; k4++)
                        {
                            if (k3 != (wielkoscElementuCalkowita - 1) / 2 && k4 != (wielkoscElementuCalkowita - 1) / 2)
                            {
                                if (strukturaElementu[k3, k4] != 999)
                                {
                                    if (tablicaErozyjna[k1, k2][k3, k4] == 255)
                                    {
                                        czyIstniejePunkt = true;
                                        //break;
                                    }
                                }
                            }
                        }
                    }

                    if (!czyIstniejePunkt)
                    {
                        t = obrazZr.GetPixel(k1, k2).R;
                        obrazWy.SetPixel(k1, k2, Color.FromArgb(t, t, t));
                    }
                    else
                    {
                        t = 255;
                        obrazWy.SetPixel(k1, k2, Color.FromArgb(t, t, t));
                    }
                }
            }
        }

        
        private void inicjalizacjaTablicy(int wielkoscElementu, int szerokoscObrazka, int wysokoscObrazka)
        {
            tablicaErozyjna = new int[szerokoscObrazkaPierwotnego, wysokoscObrazkaPierwotnego][,];

            for (int k1 = 0; k1 < szerokoscObrazkaPierwotnego; k1++)
            {
                for (int k2 = 0; k2 < wysokoscObrazkaPierwotnego; k2++)
                {
                    tablicaErozyjna[k1, k2] = new int[2 * wielkoscElementu + 1, 2 * wielkoscElementu + 1];
                }
            }
        }


    }
}
