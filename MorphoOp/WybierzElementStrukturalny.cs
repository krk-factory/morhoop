using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MorphoOp
{
    public partial class WybierzElementStrukturalny : Form
    {
        /* --- Pola klasy --- */

        private string nazwaElementu = null;
        private int wielkoscElementu1 = 0;
        private int wielkoscElementu2 = 0;

        private bool poprawnoscDanych = false;


        /* --- Metody odnoszące się bezpośrednio do okna --- */
        
        public WybierzElementStrukturalny()
        {
            InitializeComponent();
        }

        private void WybierzElementStrukturalny_Load(object sender, EventArgs e)
        {
            wyborElementuComboBox.Items.AddRange(new object[] { "Kolo", "Kwadrat", "Odcinek" });    // 0 -> Koło, 1 -> Kwadrat, 2 -> Odcinek
            
            //wyborElementuComboBox.SelectedIndex = 0;
            promienLubBokLabel.Enabled = false;
            nachylenieLabel.Enabled = false;
            nachylenieTextBox.Enabled = false;

            promienLubBokLabel.Text = "Nieaktywne";
            nachylenieLabel.Text = "Nieaktywne";

            kwadratInfoLabel.Visible = false;
        }


        /* --- Obsługa ComBoksa --- */

        private void wyborElementuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wyborElementuComboBox.SelectedIndex == 0)
            {
                promienLubBokLabel.Enabled = true;
                nachylenieLabel.Visible = true;
                nachylenieLabel.Enabled = false;
                nachylenieTextBox.Visible = true;
                nachylenieTextBox.Enabled = false;
                
                kwadratInfoLabel.Visible = false;

                promienLubBokLabel.Text = "Długość promienia";
                nachylenieLabel.Text = "Nieaktywne";
            }
            else if (wyborElementuComboBox.SelectedIndex == 1)
            {
                promienLubBokLabel.Enabled = true;

                nachylenieTextBox.Visible = false;
                nachylenieLabel.Visible = false;

                kwadratInfoLabel.Visible = true;
                kwadratInfoLabel.Text = "Bok kwadratu liczony jest wg wzoru: 2 * n + 1";

                promienLubBokLabel.Text = "n boku";
            }
            else if (wyborElementuComboBox.SelectedIndex == 2)
            {
                promienLubBokLabel.Enabled = true;
                nachylenieLabel.Visible = true;
                nachylenieLabel.Enabled = true;
                nachylenieTextBox.Visible = true;
                nachylenieTextBox.Enabled = true;

                kwadratInfoLabel.Visible = false;

                promienLubBokLabel.Text = "Długość odcinka";
                nachylenieLabel.Text = "Nachylenie odcinka";
            }
        }


        /* --- Potwierdzenie --- */

        private void potwierdzButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (wyborElementuComboBox.SelectedIndex == 0)
                {
                    nazwaElementu = (string)wyborElementuComboBox.SelectedItem;
                    wielkoscElementu1 = Convert.ToInt32(promienLubBokTextBox.Text);
                }
                else if (wyborElementuComboBox.SelectedIndex == 1)
                {
                    nazwaElementu = (string)wyborElementuComboBox.SelectedItem;
                    wielkoscElementu1 = Convert.ToInt32(promienLubBokTextBox.Text);
                }
                else if (wyborElementuComboBox.SelectedIndex == 2)
                {
                    nazwaElementu = (string)wyborElementuComboBox.SelectedItem;
                    wielkoscElementu1 = Convert.ToInt32(promienLubBokTextBox.Text);
                    wielkoscElementu2 = Convert.ToInt32(nachylenieTextBox.Text);
                }

                poprawnoscDanych = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błąd formatu!\n" + ex.Message);
                poprawnoscDanych = false;
            }

            if (wielkoscElementu1 < 0 || wielkoscElementu2 < 0)
            {
                MessageBox.Show("Dane nie mogą być ujemne! Wprowadź je jeszcze raz.");
                poprawnoscDanych = false;
            }

            this.Close();
        }


        /* --- Właściwości --- */

        public string NazwaElementu
        {
            get { return nazwaElementu; }
        }

        public int WielkoscElementu
        {
            get { return wielkoscElementu1; }
        }

        public int Nachylenie
        {
            get { return wielkoscElementu2; }
        }

        public bool PoprawnoscDanych
        {
            get { return poprawnoscDanych; }
        }
    }
}
