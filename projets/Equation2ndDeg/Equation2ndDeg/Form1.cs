using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equation2ndDeg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtValid_Click(object sender, EventArgs e)
        {
            double coef_x2 = 0, coef_x = 0, coef_reel = 0;
            double partieReelle, partieImaginaire;

            try
            {
                //On récupère les valeurs
                if (this.coef_x2.Text != "")
                {
                    coef_x2 = Convert.ToDouble(this.coef_x2.Text);
                }
                else
                {
                    this.coef_x2.Text = "0";
                }
                if (this.coef_x.Text != "")
                {
                    coef_x = Convert.ToDouble(this.coef_x.Text);
                }
                else
                {
                    this.coef_x.Text = "0";
                }
                if (this.coef_reel.Text != "")
                {
                    coef_reel = Convert.ToDouble(this.coef_reel.Text);
                }
                else
                {
                    this.coef_reel.Text = "0";
                }

                //Affichage
                if (coef_x2 != 0)
                {
                    double delta = coef_x * coef_x - 4 * coef_x2 * coef_reel;
                    if (delta < 0)
                    {
                        if (radioButtonReel.Checked == true)
                        {
                            this.LabelNbSol.Text = "Pas de solutions réelles";
                            this.LabelSolX1.Text = "";
                            this.LabelSolX2.Text = "";
                        }
                        if (radioButtonComplexe.Checked == true)
                        {
                            this.LabelNbSol.Text = "Deux solutions complexes";
                            partieReelle = - coef_x / (2 * coef_x2);
                            partieImaginaire = Math.Sqrt(- delta) / (2 * coef_x2);
                            this.LabelSolX1.Text = partieReelle.ToString() + " + " + partieImaginaire.ToString() + "i";
                            this.LabelSolX2.Text = partieReelle.ToString() + " - " + partieImaginaire.ToString() + "i";
                        }
                    }
                    if (delta == 0)
                    {
                        double sol = -coef_x / (2 * coef_x2);
                        this.LabelNbSol.Text = "Une solution réelle :";
                        this.LabelSolX1.Text = "x = " + sol.ToString();
                        this.LabelSolX2.Text = "";
                    }
                    if (delta > 0)
                    {
                        double sol1 = ((-coef_x - Math.Sqrt(delta)) / (2 * coef_x2));
                        double sol2 = ((-coef_x + Math.Sqrt(delta)) / (2 * coef_x2));
                        this.LabelNbSol.Text = "Deux solutions réelles :";
                        this.LabelSolX1.Text = "x1 = " + sol1.ToString();
                        this.LabelSolX2.Text = "x2 = " + sol2.ToString();
                    }
                }
                else
                {
                    if (coef_x != 0)
                    {
                        double sol = -coef_reel / coef_x;
                        this.LabelNbSol.Text = "Une solution réelle :";
                        this.LabelSolX1.Text = "x = " + sol.ToString();
                        this.LabelSolX2.Text = "";
                    }
                    else
                    {
                        this.LabelNbSol.Text = "Pas de solution";
                        this.LabelSolX1.Text = "";
                        this.LabelSolX2.Text = "";
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur : " + err);
            }
        }
    }
}
