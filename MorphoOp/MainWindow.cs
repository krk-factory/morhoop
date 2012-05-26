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
        private int wysokoscObrazka;
        private int szerokoscObrazka;

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

                    szerokoscObrazka = obrazWejsciowy.Size.Width;
                    wysokoscObrazka = obrazWejsciowy.Size.Height;

                    obrazWejsciowyPictureBox.Image = obrazWejsciowy;
                    obrazWyjsciowyPictureBox.Image = null;

                    elementStrukturalnyToolStripMenuItem.Enabled = true;

                    //udostepnianieOperacji(true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd odczytu pliku. Błąd: " + ex.Message);
                }
            }
            else
            {
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
                        daneElementuLabel.Text = "" + elStr.NazwaElementu + " o boku " + elStr.WielkoscElementu;
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
    }
}
