namespace tp3_doolaeghe_mail_url
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMailTitre = new System.Windows.Forms.Label();
            this.labelMailValidite = new System.Windows.Forms.Label();
            this.labelMailLongueur = new System.Windows.Forms.Label();
            this.labelMailPartieNom = new System.Windows.Forms.Label();
            this.labelMailPartieDomaine = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelURLPort = new System.Windows.Forms.Label();
            this.labelURLServeur = new System.Windows.Forms.Label();
            this.labelURLMdp = new System.Windows.Forms.Label();
            this.labelURLProtocole = new System.Windows.Forms.Label();
            this.labelURLTitre = new System.Windows.Forms.Label();
            this.labelURLChemin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMailTitre
            // 
            this.labelMailTitre.AutoSize = true;
            this.labelMailTitre.Location = new System.Drawing.Point(106, 84);
            this.labelMailTitre.Name = "labelMailTitre";
            this.labelMailTitre.Size = new System.Drawing.Size(33, 18);
            this.labelMailTitre.TabIndex = 0;
            this.labelMailTitre.Text = "Mail";
            this.labelMailTitre.Click += new System.EventHandler(this.labelMailTitre_Click);
            // 
            // labelMailValidite
            // 
            this.labelMailValidite.AutoSize = true;
            this.labelMailValidite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelMailValidite.Location = new System.Drawing.Point(142, 132);
            this.labelMailValidite.Name = "labelMailValidite";
            this.labelMailValidite.Size = new System.Drawing.Size(0, 18);
            this.labelMailValidite.TabIndex = 2;
            // 
            // labelMailLongueur
            // 
            this.labelMailLongueur.AutoSize = true;
            this.labelMailLongueur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelMailLongueur.Location = new System.Drawing.Point(142, 150);
            this.labelMailLongueur.Name = "labelMailLongueur";
            this.labelMailLongueur.Size = new System.Drawing.Size(0, 18);
            this.labelMailLongueur.TabIndex = 3;
            // 
            // labelMailPartieNom
            // 
            this.labelMailPartieNom.AutoSize = true;
            this.labelMailPartieNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelMailPartieNom.Location = new System.Drawing.Point(142, 168);
            this.labelMailPartieNom.Name = "labelMailPartieNom";
            this.labelMailPartieNom.Size = new System.Drawing.Size(0, 18);
            this.labelMailPartieNom.TabIndex = 4;
            // 
            // labelMailPartieDomaine
            // 
            this.labelMailPartieDomaine.AutoSize = true;
            this.labelMailPartieDomaine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelMailPartieDomaine.Location = new System.Drawing.Point(142, 186);
            this.labelMailPartieDomaine.Name = "labelMailPartieDomaine";
            this.labelMailPartieDomaine.Size = new System.Drawing.Size(0, 18);
            this.labelMailPartieDomaine.TabIndex = 5;
            // 
            // textBoxMail
            // 
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMail.Location = new System.Drawing.Point(145, 82);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(441, 25);
            this.textBoxMail.TabIndex = 6;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // textBoxURL
            // 
            this.textBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxURL.Location = new System.Drawing.Point(145, 231);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(441, 25);
            this.textBoxURL.TabIndex = 12;
            this.textBoxURL.Text = "http://www.commentcamarche.net/forum/index.php3?cat=1&page2";
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // labelURLPort
            // 
            this.labelURLPort.AutoSize = true;
            this.labelURLPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelURLPort.Location = new System.Drawing.Point(142, 335);
            this.labelURLPort.Name = "labelURLPort";
            this.labelURLPort.Size = new System.Drawing.Size(0, 18);
            this.labelURLPort.TabIndex = 11;
            // 
            // labelURLServeur
            // 
            this.labelURLServeur.AutoSize = true;
            this.labelURLServeur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelURLServeur.Location = new System.Drawing.Point(142, 317);
            this.labelURLServeur.Name = "labelURLServeur";
            this.labelURLServeur.Size = new System.Drawing.Size(0, 18);
            this.labelURLServeur.TabIndex = 10;
            // 
            // labelURLMdp
            // 
            this.labelURLMdp.AutoSize = true;
            this.labelURLMdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelURLMdp.Location = new System.Drawing.Point(142, 299);
            this.labelURLMdp.Name = "labelURLMdp";
            this.labelURLMdp.Size = new System.Drawing.Size(0, 18);
            this.labelURLMdp.TabIndex = 9;
            // 
            // labelURLProtocole
            // 
            this.labelURLProtocole.AutoSize = true;
            this.labelURLProtocole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelURLProtocole.Location = new System.Drawing.Point(142, 281);
            this.labelURLProtocole.Name = "labelURLProtocole";
            this.labelURLProtocole.Size = new System.Drawing.Size(0, 18);
            this.labelURLProtocole.TabIndex = 8;
            // 
            // labelURLTitre
            // 
            this.labelURLTitre.AutoSize = true;
            this.labelURLTitre.Location = new System.Drawing.Point(106, 233);
            this.labelURLTitre.Name = "labelURLTitre";
            this.labelURLTitre.Size = new System.Drawing.Size(32, 18);
            this.labelURLTitre.TabIndex = 7;
            this.labelURLTitre.Text = "URL";
            // 
            // labelURLChemin
            // 
            this.labelURLChemin.AutoSize = true;
            this.labelURLChemin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelURLChemin.Location = new System.Drawing.Point(142, 353);
            this.labelURLChemin.Name = "labelURLChemin";
            this.labelURLChemin.Size = new System.Drawing.Size(0, 18);
            this.labelURLChemin.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 459);
            this.Controls.Add(this.labelURLChemin);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelURLPort);
            this.Controls.Add(this.labelURLServeur);
            this.Controls.Add(this.labelURLMdp);
            this.Controls.Add(this.labelURLProtocole);
            this.Controls.Add(this.labelURLTitre);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMailPartieDomaine);
            this.Controls.Add(this.labelMailPartieNom);
            this.Controls.Add(this.labelMailLongueur);
            this.Controls.Add(this.labelMailValidite);
            this.Controls.Add(this.labelMailTitre);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMailTitre;
        private System.Windows.Forms.Label labelMailValidite;
        private System.Windows.Forms.Label labelMailLongueur;
        private System.Windows.Forms.Label labelMailPartieNom;
        private System.Windows.Forms.Label labelMailPartieDomaine;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelURLPort;
        private System.Windows.Forms.Label labelURLServeur;
        private System.Windows.Forms.Label labelURLMdp;
        private System.Windows.Forms.Label labelURLProtocole;
        private System.Windows.Forms.Label labelURLTitre;
        private System.Windows.Forms.Label labelURLChemin;
    }
}

