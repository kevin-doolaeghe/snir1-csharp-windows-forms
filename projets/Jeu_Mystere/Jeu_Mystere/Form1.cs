using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_Mystere
{
    public partial class Form1 : Form
    {
        private int compt = 1;

        private int alea = new Random().Next(1, 100);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valTextBox = 1;

            if (this.textBox1.Text != "")
            {
                valTextBox = Convert.ToInt32(this.textBox1.Text);
            }
            else
            {
                this.textBox1.Text = "1";
            }

            if (valTextBox > 0 && valTextBox <= 100)
            {
                int percent = 100 - Math.Abs(valTextBox - alea);
                this.progressBar1.Value = percent;
                this.pourcentage.Text = "Proximité : " + percent.ToString() + "%";

                if (valTextBox == alea)
                {
                    this.label1.Text = "Gagné ! Il vous a fallu " + compt + " essais.";
                }
                else
                {
                    compt++;
                    this.essais.Text = "Essais n° " + compt;
                    if (valTextBox > alea)
                    {
                        this.label1.Text = "Trop grand !";
                    }
                    if (valTextBox < alea)
                    {
                        this.label1.Text = "Trop petit !";
                    }
                }
            }
            else
            {
                this.label1.Text = "Vous devez entrer un nombre entre 1 et 100";
            }
        }
    }
}
