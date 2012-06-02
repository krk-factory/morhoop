using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MorphoOp
{
    public partial class MainWindow : Form
    {
        /* --- Pola klasy --- */
        
        private Bitmap obrazWejsciowy;    // ew. zrobić public, aby korzystać z niego wszędzie

        private ElementStrukt elStr;


        /* --- Metody odnoszące się bezpośrednio do głównego okna --- */

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            obrazWejsciowyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            obrazWyjsciowyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            operacjaToolStripMenuItem.Enabled = false;
            elementStrukturalnyToolStripMenuItem.Enabled = false;
            operacjeBezESToolStripMenuItem.Enabled = false;
        }


        /* --- Obługa menu --- */

        private void udostepnianieOperacji(bool b)
        {
            operacjaToolStripMenuItem.Enabled = b;
        }
        
        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void otworzObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sciezkaPliku;
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Pliki graficzne (*.jpg)|*.jpg|Pliki graficzne (*.gif)|*.gif|Pliki graficzne (*.tif)|*.tif|Pliki graficzne (*.bmp)|*.bmp|Wszystkie pliki (*.*)|*.*";
            ofd.FilterIndex = 5;
            ofd.RestoreDirectory = true;
            ofd.Title = "Otwórz plik...";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sciezkaPliku = ofd.FileName;

                try
                {
                    obrazWejsciowy = new Bitmap(sciezkaPliku);

                    obrazWejsciowyPictureBox.Image = obrazWejsciowy;
                    obrazWyjsciowyPictureBox.Image = null;

                    elementStrukturalnyToolStripMenuItem.Enabled = true;
                    operacjeBezESToolStripMenuItem.Enabled = true;

                    //udostepnianieOperacji(true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd odczytu pliku. Błąd: " + ex.Message);
                }
            }
            else
            {
                operacjeBezESToolStripMenuItem.Enabled = false;
                //udostepnianieOperacji(false);
            }

            obrazWyjsciowyPictureBox.Image = null;
        }

        private void zapiszObrazWyjsciowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Pliki graficzne (*.jpg)|*.jpg|Pliki graficzne (*.gif)|*.gif|Pliki graficzne (*.tif)|*.tif|Pliki graficzne (*.bmp)|*.bmp|Wszystkie pliki (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            sfd.Title = "Zapisz plik...";

            sfd.ShowDialog();

            // Jeśli nie ma stringu z nazwą, nie zapisuj
            if (sfd.FileName != "")
            {
                try
                {
                    // Zapis przez FileStream stworzony przez metodę OpenFile
                    FileStream fs = (FileStream)sfd.OpenFile();
                    // Zapis pliku względem dostępnych formatów
                    switch (sfd.FilterIndex)
                    {
                        case 1:
                            obrazWyjsciowyPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            obrazWyjsciowyPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                            break;

                        case 3:
                            obrazWyjsciowyPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Tiff);
                            break;

                        case 4:
                            obrazWyjsciowyPictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                    }

                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd!\n\n" + ex.Message);
                }
            }
        }

        private void elementStrukturalnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WybierzElementStrukturalny wes = new WybierzElementStrukturalny();

            wes.ShowDialog();

            if (wes.PoprawnoscDanych)
            {
                switch (wes.NazwaElementu)
                {
                    case "Kwadrat":
                        elStr = new Kwadrat(wes.WielkoscElementu);
                        daneElementuLabel.Text = "" + elStr.NazwaElementu + " o boku o n = " + elStr.WielkoscElementu;
                        break;
                    case "Kolo":
                        elStr = new Kolo(wes.WielkoscElementu);
                        daneElementuLabel.Text = "" + elStr.NazwaElementu + " o promieniu " + elStr.WielkoscElementu;
                        break;
                    case "Odcinek":
                        elStr = new Odcinek(wes.WielkoscElementu, wes.Nachylenie);
                        daneElementuLabel.Text = "" + elStr.NazwaElementu + " o długości " + elStr.WielkoscElementu + " i nachyleniu " + elStr.Nachylenie + " stopni";
                        break;
                }
            }
            else
            {
                daneElementuLabel.Text = "BRAK";
            }

            obrazWyjsciowyPictureBox.Image = null;
            udostepnianieOperacji(wes.PoprawnoscDanych);

            //MessageBox.Show("1: " + elStr.NazwaElementu + ", 2: " + elStr.PromienLubBok);   // DEBUG
        }

        private void erozjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurBitmap temp = rozszerzObraz(obrazWejsciowy, elStr.WielkoscElementu);

            Erozja er = new Erozja(obrazWejsciowy, temp, elStr);

            obrazWyjsciowyPictureBox.Image = er.wykonajOperacje();
        }

        private void dylatacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurBitmap temp = rozszerzObraz(obrazWejsciowy, elStr.WielkoscElementu);

            Dylatacja er = new Dylatacja(obrazWejsciowy, temp, elStr);

            obrazWyjsciowyPictureBox.Image = er.wykonajOperacje();
        }

        private void otwarcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurBitmap temp = rozszerzObraz(obrazWejsciowy, elStr.WielkoscElementu);

            Erozja er = new Erozja(obrazWejsciowy, temp, elStr);

            Bitmap temp2 = er.wykonajOperacje();

            OurBitmap temp3 = rozszerzObraz(temp2, elStr.WielkoscElementu);

            Dylatacja dyl = new Dylatacja(temp2, temp3, elStr);

            obrazWyjsciowyPictureBox.Image = dyl.wykonajOperacje();
        }

        private void zamkniecieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurBitmap temp = rozszerzObraz(obrazWejsciowy, elStr.WielkoscElementu);

            Dylatacja er = new Dylatacja(obrazWejsciowy, temp, elStr);

            Bitmap temp2 = er.wykonajOperacje();

            OurBitmap temp3 = rozszerzObraz(temp2, elStr.WielkoscElementu);

            Erozja dyl = new Erozja(temp2, temp3, elStr);

            obrazWyjsciowyPictureBox.Image = dyl.wykonajOperacje();
        }

        private void filtracjaZMaskaPrewittaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurBitmap temp = rozszerzObraz(obrazWejsciowy, 1);

            FiltracjaPrewitt er = new FiltracjaPrewitt(obrazWejsciowy, temp);

            obrazWyjsciowyPictureBox.Image = er.wykonajOperacje();
        }

        private void filtracjaZMaskaSobelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurBitmap temp = rozszerzObraz(obrazWejsciowy, 1);

            FiltracjaSobel er = new FiltracjaSobel(obrazWejsciowy, temp);

            obrazWyjsciowyPictureBox.Image = er.wykonajOperacje();
        }


        /* --- Rozszerzanie obrazka - ew. wyodrębnić jako kolejną klasę --- */

        private OurBitmap rozszerzObraz(Bitmap obrazWejsciowy, int wielkoscElementu)        // Potrzebne, aby wykonać poszczególne operacje na krawędziach obrazka
        {                                                       // Trochę pochrzanione z indeksami, ale działa ;-)
            OurBitmap obrazTmp = new OurBitmap(obrazWejsciowy.Width + 2 * wielkoscElementu, obrazWejsciowy.Height + 2 * wielkoscElementu);

            int t;

            for (int k1 = 0; k1 < obrazTmp.image.Height; k1++)
            {
                for (int k2 = 0; k2 < obrazTmp.image.Width; k2++)
                {
                    // PASKI
                    if (k2 >= wielkoscElementu && k2 <= (wielkoscElementu + (obrazWejsciowy.Width-1)) && k1 < wielkoscElementu)
                    {
                        t = obrazWejsciowy.GetPixel(k2 - wielkoscElementu, 0).R;

                        obrazTmp.image.SetPixel(k2, k1, Color.FromArgb(t, t, t));
                    }
                    else if (k2 >= wielkoscElementu && k2 <= (wielkoscElementu + (obrazWejsciowy.Width - 1)) && k1 > (wielkoscElementu + (obrazWejsciowy.Height - 1)))
                    {
                        t = obrazWejsciowy.GetPixel(k2 - wielkoscElementu, obrazWejsciowy.Height - 1).R;

                        obrazTmp.image.SetPixel(k2, k1, Color.FromArgb(t, t, t));
                    }
                    else if (k2 < wielkoscElementu && k1 >= wielkoscElementu && k1 <= (wielkoscElementu + (obrazWejsciowy.Height-1)))
                    {
                        t = obrazWejsciowy.GetPixel(0, k1 - wielkoscElementu).R;

                        obrazTmp.image.SetPixel(k2, k1, Color.FromArgb(t, t, t));
                    }
                    else if (k2 > (wielkoscElementu + (obrazWejsciowy.Width-1)) && k1 >= wielkoscElementu && k1 <= (wielkoscElementu + (obrazWejsciowy.Height-1)))
                    {
                        t = obrazWejsciowy.GetPixel(obrazWejsciowy.Width - 1, k1 - wielkoscElementu).R;

                        obrazTmp.image.SetPixel(k2, k1, Color.FromArgb(t, t, t));
                    }
                    // ROGI
                    else if (k2 < wielkoscElementu && k1 < wielkoscElementu)
                    {
                        t = obrazWejsciowy.GetPixel(0, 0).R;

                        obrazTmp.image.SetPixel(k2, k1, Color.FromArgb(t, t, t));
                    }
                    else if (k2 > (wielkoscElementu + (obrazWejsciowy.Width-1)) && k1 < wielkoscElementu)
                    {
                        t = obrazWejsciowy.GetPixel(obrazWejsciowy.Width - 1, 0).R;

                        obrazTmp.image.SetPixel(k2, k1, Color.FromArgb(t, t, t));
                    }
                    else if (k2 < wielkoscElementu && k1 > (wielkoscElementu + (obrazWejsciowy.Height-1)))
                    {
                        t = obrazWejsciowy.GetPixel(0, obrazWejsciowy.Height - 1).R;

                        obrazTmp.image.SetPixel(k2, k1, Color.FromArgb(t, t, t));
                    }
                    else if (k2 > (wielkoscElementu + (obrazWejsciowy.Width-1)) && k1 > (wielkoscElementu + (obrazWejsciowy.Height-1)))
                    {
                        t = obrazWejsciowy.GetPixel(obrazWejsciowy.Width - 1, obrazWejsciowy.Height - 1).R;

                        obrazTmp.image.SetPixel(k2, k1, Color.FromArgb(t, t, t));
                    }
                    // POZOSTAŁE
                    else
                    {
                        t = obrazWejsciowy.GetPixel(k2 - wielkoscElementu, k1 - wielkoscElementu).R;
                        obrazTmp.image.SetPixel(k2, k1, Color.FromArgb(t, t, t));
                    }
                }
            }
            return obrazTmp;
        }

        private void gradientMorfologicznyDylatacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurBitmap temp = rozszerzObraz(obrazWejsciowy, elStr.WielkoscElementu);
            
            GradientMorfoDylatacja er = new GradientMorfoDylatacja(obrazWejsciowy, temp, elStr);

            obrazWyjsciowyPictureBox.Image = er.wykonajOperacje();
        }

        private void gradientMorfologicznyErozjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OurBitmap temp = rozszerzObraz(obrazWejsciowy, elStr.WielkoscElementu);

            GradientMorfoErozja er = new GradientMorfoErozja(obrazWejsciowy, temp, elStr);

            obrazWyjsciowyPictureBox.Image = er.wykonajOperacje();
        }       
    }
}
