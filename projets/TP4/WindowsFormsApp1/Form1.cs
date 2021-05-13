using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const int taille = 20;
        private const int min = 1;
        private const int max = 100;
        private int[] tabValeurs;

        public Form1()
        {
            InitializeComponent();
            tabValeurs = new int[taille] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        }

        private void buttonAffich_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < taille; i++)
            {
                listBoxTableau.Items.Add(tabValeurs[i]);
            }
        }

        private void buttonAffAlea_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < taille; i++)
            {
                tabValeurs[i] = randomNumber(min, max);
            }
        }

        private void buttonMinMax_Click(object sender, EventArgs e)
        {
            int min = tabValeurs[0];
            int max = min;

            for(int i = 0; i < taille; i++)
            {
                if(tabValeurs[i] < min) { min = tabValeurs[i]; }
                if(tabValeurs[i] > min) { max = tabValeurs[i]; }
            }

            labelMinMax.Text = "Min : " + Convert.ToString(min) + " | Max : " + Convert.ToString(max);
        }

        private void buttonMoyenne_Click(object sender, EventArgs e)
        {
            int somme = 0;

            for(int i = 0; i < taille; i++)
            {
                somme += tabValeurs[i];
            }

            labelMoyenne.Text = "Moyenne : " + Convert.ToString(somme / taille);
        }

        private void buttonBinarisation_Click(object sender, EventArgs e)
        {
            if(textBoxSeuil.Text.Length == 0) textBoxSeuil.Text = "20";
            int seuil = Convert.ToInt32(textBoxSeuil.Text);

            for(int i = 0; i < taille; i++)
            {
                if (tabValeurs[i] > seuil) tabValeurs[i] = 1;
                else tabValeurs[i] = 0;
            }
        }

        private void buttonLissagex3_Click(object sender, EventArgs e)
        {
            int[] tab = new int[taille];

            for(int i = 1; i < taille - 1; i++)
            {
                tab[i] = (tabValeurs[i - 1] + tabValeurs[i] + tabValeurs[i + 1]) / 3;
            }

            tab[0] = tab[1];
            tab[taille - 1] = tab[taille - 2];

            for (int i = 0; i < taille; i++)
            {
                tabValeurs[i] = tab[i];
            }
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            listBoxTableau.Items.Clear();
        }

        private int randomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        private void buttonCalculMens_Click(object sender, EventArgs e)
        {
            double montant = Convert.ToDouble(textBoxMontant.Text);
            double taux = Convert.ToDouble(textBoxTaux.Text) / 100;
            double nbMens = Convert.ToDouble(textBoxNbMens.Text);

            double montantMens = (montant * taux / 12) / (1 - Math.Pow((1 + taux / 12), -nbMens));
            labelMontantMens.Text = "Montant mensualité : " + montantMens.ToString() + "€";
        }
    }
}
