using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace tp3_doolaeghe_mail_url
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelMailTitre_Click(object sender, EventArgs e)
        {
            textBoxMail.Focus();
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            //Mail
            String emailString = this.textBoxMail.Text;
            String nom, domaine;
            int indexArobas;
            Regex emailRegex = new Regex("^[a-zA-Z0-9_.-]+@{1}[a-zA-Z0-9_.-]{2,}\\.[a-zA-Z0-9_.-]{2,4}$");
            
            if (emailRegex.IsMatch(textBoxMail.Text))
            {
                labelMailValidite.Text = "@Email valide";
            }
            else
            {
                labelMailValidite.Text = "@Email invalide";
            }
            labelMailLongueur.Text = "Longueur totale : " + emailString.Length;
            indexArobas = emailString.IndexOf('@');
            if (indexArobas != -1)
            {
                nom = emailString.Substring(0, indexArobas);
                domaine = emailString.Substring(indexArobas + 1, emailString.Length - indexArobas - 1);
                labelMailPartieNom.Text = "Nom : " + nom;
                labelMailPartieDomaine.Text = "Domaine : " + domaine;
            }
            else
            {
                labelMailPartieNom.Text = "";
                labelMailPartieDomaine.Text = "";
            }
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            //URL
            String url = this.textBoxURL.Text;
            String[] tabSplit = url.Split(new[] { ':', '/', '@' });
            String urlProtocole, urlMdp, urlServeur, urlPort, urlChemin = "";
            bool isProtocole = false, isMdp = false, isPort = false;
            short i;

            //Séparation
            if (url.Split('@').Length == 2)
            {
                isMdp = true;
            }
            switch (url.Split(':').Length)
            {
                case 2:
                    if (url.IndexOf("://") != -1)
                    {
                        isProtocole = true;
                        isPort = false;
                    }
                    else
                    {
                        isProtocole = false;
                        isPort = true;
                    }
                    break;
                case 3:
                    isProtocole = true;
                    isPort = true;
                    break;
            }

            if (isProtocole == true)
            {
                urlProtocole = url.Split(':')[0];
            }
            else
            {
                urlProtocole = "http";
            }
            if (isMdp == true)
            {
                if (isProtocole == true)
                {
                    urlMdp = url.Split(new[] { ':', '/', '@' })[3];
                }
                else
                {
                    urlMdp = url.Split('@')[0];
                }
            }
            else
            {
                urlMdp = "";
            }
            if (isProtocole == true)
            {
                if (isMdp == true)
                {
                    urlServeur = url.Split(new[] { ':', '/', '@' })[4];
                }
                else
                {
                    urlServeur = url.Split(new[] { ':', '/', '@' })[3];
                }
            }
            else
            {
                if (isMdp == true)
                {
                    urlServeur = url.Split(new[] { ':', '/', '@' })[1];
                }
                else
                {
                    urlServeur = url.Split(new[] { ':', '/', '@' })[0];
                }
            }
            if (isPort == true)
            {
                if (isProtocole == true)
                {
                    urlPort = url.Split(new[] { ':', '/' })[4];
                }
                else
                {
                    urlPort = url.Split(new[] { ':', '/' })[1];
                }
            }
            else
            {
                urlPort = "80";
            }
            if (isProtocole == true)
            {
                for (i = 3; i < url.Split(new[] { '/' }).Length; i++)
                {
                    urlChemin += '/' + url.Split(new[] { '/' })[i];
                }
            }
            else
            {
                for (i = 1; i < url.Split(new[] { '/' }).Length; i++)
                {
                    urlChemin += '/' + url.Split(new[] { '/' })[i];
                }
            }

            //Affichage
            labelURLProtocole.Text = "Protocole : " + urlProtocole;
            labelURLMdp.Text = "Mot de passe : " + urlMdp;
            labelURLServeur.Text = "Serveur : " + urlServeur;
            labelURLPort.Text = "Port : " + urlPort;
            labelURLChemin.Text = "Chemin : " + urlChemin;
        }
    }
}
