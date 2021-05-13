namespace WindowsFormsApp1
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
            this.listBoxTableau = new System.Windows.Forms.ListBox();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.buttonAffich = new System.Windows.Forms.Button();
            this.buttonAffAlea = new System.Windows.Forms.Button();
            this.buttonMinMax = new System.Windows.Forms.Button();
            this.buttonMoyenne = new System.Windows.Forms.Button();
            this.buttonBinarisation = new System.Windows.Forms.Button();
            this.buttonLissagex3 = new System.Windows.Forms.Button();
            this.labelMinMax = new System.Windows.Forms.Label();
            this.labelMoyenne = new System.Windows.Forms.Label();
            this.labelSeuil = new System.Windows.Forms.Label();
            this.textBoxSeuil = new System.Windows.Forms.TextBox();
            this.labelMensualite = new System.Windows.Forms.Label();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.textBoxTaux = new System.Windows.Forms.TextBox();
            this.textBoxNbMens = new System.Windows.Forms.TextBox();
            this.buttonCalculMens = new System.Windows.Forms.Button();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelTaux = new System.Windows.Forms.Label();
            this.labelTauxMens = new System.Windows.Forms.Label();
            this.labelMontantMens = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTableau
            // 
            this.listBoxTableau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTableau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listBoxTableau.FormattingEnabled = true;
            this.listBoxTableau.ItemHeight = 20;
            this.listBoxTableau.Location = new System.Drawing.Point(14, 14);
            this.listBoxTableau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxTableau.Name = "listBoxTableau";
            this.listBoxTableau.Size = new System.Drawing.Size(193, 422);
            this.listBoxTableau.TabIndex = 0;
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEffacer.Location = new System.Drawing.Point(46, 465);
            this.buttonEffacer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(122, 45);
            this.buttonEffacer.TabIndex = 1;
            this.buttonEffacer.Text = "Effacer";
            this.buttonEffacer.UseVisualStyleBackColor = true;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // buttonAffich
            // 
            this.buttonAffich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAffich.Location = new System.Drawing.Point(398, 14);
            this.buttonAffich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAffich.Name = "buttonAffich";
            this.buttonAffich.Size = new System.Drawing.Size(213, 45);
            this.buttonAffich.TabIndex = 2;
            this.buttonAffich.Text = "Afficher tableau";
            this.buttonAffich.UseVisualStyleBackColor = true;
            this.buttonAffich.Click += new System.EventHandler(this.buttonAffich_Click);
            // 
            // buttonAffAlea
            // 
            this.buttonAffAlea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAffAlea.Location = new System.Drawing.Point(398, 66);
            this.buttonAffAlea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAffAlea.Name = "buttonAffAlea";
            this.buttonAffAlea.Size = new System.Drawing.Size(213, 45);
            this.buttonAffAlea.TabIndex = 3;
            this.buttonAffAlea.Text = "Remplir aléatoirement";
            this.buttonAffAlea.UseVisualStyleBackColor = true;
            this.buttonAffAlea.Click += new System.EventHandler(this.buttonAffAlea_Click);
            // 
            // buttonMinMax
            // 
            this.buttonMinMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinMax.Location = new System.Drawing.Point(398, 159);
            this.buttonMinMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMinMax.Name = "buttonMinMax";
            this.buttonMinMax.Size = new System.Drawing.Size(213, 45);
            this.buttonMinMax.TabIndex = 4;
            this.buttonMinMax.Text = "Minimim et maximum";
            this.buttonMinMax.UseVisualStyleBackColor = true;
            this.buttonMinMax.Click += new System.EventHandler(this.buttonMinMax_Click);
            // 
            // buttonMoyenne
            // 
            this.buttonMoyenne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMoyenne.Location = new System.Drawing.Point(398, 211);
            this.buttonMoyenne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMoyenne.Name = "buttonMoyenne";
            this.buttonMoyenne.Size = new System.Drawing.Size(213, 45);
            this.buttonMoyenne.TabIndex = 5;
            this.buttonMoyenne.Text = "Moyenne";
            this.buttonMoyenne.UseVisualStyleBackColor = true;
            this.buttonMoyenne.Click += new System.EventHandler(this.buttonMoyenne_Click);
            // 
            // buttonBinarisation
            // 
            this.buttonBinarisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBinarisation.Location = new System.Drawing.Point(398, 327);
            this.buttonBinarisation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBinarisation.Name = "buttonBinarisation";
            this.buttonBinarisation.Size = new System.Drawing.Size(213, 45);
            this.buttonBinarisation.TabIndex = 6;
            this.buttonBinarisation.Text = "Binarisation";
            this.buttonBinarisation.UseVisualStyleBackColor = true;
            this.buttonBinarisation.Click += new System.EventHandler(this.buttonBinarisation_Click);
            // 
            // buttonLissagex3
            // 
            this.buttonLissagex3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLissagex3.Location = new System.Drawing.Point(398, 379);
            this.buttonLissagex3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLissagex3.Name = "buttonLissagex3";
            this.buttonLissagex3.Size = new System.Drawing.Size(213, 45);
            this.buttonLissagex3.TabIndex = 7;
            this.buttonLissagex3.Text = "Lissage x3";
            this.buttonLissagex3.UseVisualStyleBackColor = true;
            this.buttonLissagex3.Click += new System.EventHandler(this.buttonLissagex3_Click);
            // 
            // labelMinMax
            // 
            this.labelMinMax.AutoSize = true;
            this.labelMinMax.Location = new System.Drawing.Point(653, 172);
            this.labelMinMax.Name = "labelMinMax";
            this.labelMinMax.Size = new System.Drawing.Size(88, 20);
            this.labelMinMax.TabIndex = 8;
            this.labelMinMax.Text = "Min : | Max :";
            // 
            // labelMoyenne
            // 
            this.labelMoyenne.AutoSize = true;
            this.labelMoyenne.Location = new System.Drawing.Point(653, 224);
            this.labelMoyenne.Name = "labelMoyenne";
            this.labelMoyenne.Size = new System.Drawing.Size(77, 20);
            this.labelMoyenne.TabIndex = 9;
            this.labelMoyenne.Text = "Moyenne :";
            // 
            // labelSeuil
            // 
            this.labelSeuil.AutoSize = true;
            this.labelSeuil.Location = new System.Drawing.Point(653, 340);
            this.labelSeuil.Name = "labelSeuil";
            this.labelSeuil.Size = new System.Drawing.Size(82, 20);
            this.labelSeuil.TabIndex = 10;
            this.labelSeuil.Text = "Avec seuil :";
            // 
            // textBoxSeuil
            // 
            this.textBoxSeuil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSeuil.Location = new System.Drawing.Point(742, 336);
            this.textBoxSeuil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSeuil.Name = "textBoxSeuil";
            this.textBoxSeuil.Size = new System.Drawing.Size(162, 27);
            this.textBoxSeuil.TabIndex = 11;
            // 
            // labelMensualite
            // 
            this.labelMensualite.AutoSize = true;
            this.labelMensualite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensualite.Location = new System.Drawing.Point(457, 517);
            this.labelMensualite.Name = "labelMensualite";
            this.labelMensualite.Size = new System.Drawing.Size(310, 25);
            this.labelMensualite.TabIndex = 12;
            this.labelMensualite.Text = "Calcul des mensualités d\'emprunt";
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMontant.Location = new System.Drawing.Point(187, 549);
            this.textBoxMontant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(162, 27);
            this.textBoxMontant.TabIndex = 13;
            // 
            // textBoxTaux
            // 
            this.textBoxTaux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTaux.Location = new System.Drawing.Point(187, 584);
            this.textBoxTaux.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTaux.Name = "textBoxTaux";
            this.textBoxTaux.Size = new System.Drawing.Size(162, 27);
            this.textBoxTaux.TabIndex = 14;
            // 
            // textBoxNbMens
            // 
            this.textBoxNbMens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNbMens.Location = new System.Drawing.Point(187, 619);
            this.textBoxNbMens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNbMens.Name = "textBoxNbMens";
            this.textBoxNbMens.Size = new System.Drawing.Size(162, 27);
            this.textBoxNbMens.TabIndex = 15;
            // 
            // buttonCalculMens
            // 
            this.buttonCalculMens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculMens.Location = new System.Drawing.Point(398, 675);
            this.buttonCalculMens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalculMens.Name = "buttonCalculMens";
            this.buttonCalculMens.Size = new System.Drawing.Size(244, 37);
            this.buttonCalculMens.TabIndex = 17;
            this.buttonCalculMens.Text = "Calcul montant mensualité";
            this.buttonCalculMens.UseVisualStyleBackColor = true;
            this.buttonCalculMens.Click += new System.EventHandler(this.buttonCalculMens_Click);
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(12, 551);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(72, 20);
            this.labelMontant.TabIndex = 18;
            this.labelMontant.Text = "Montant :";
            // 
            // labelTaux
            // 
            this.labelTaux.AutoSize = true;
            this.labelTaux.Location = new System.Drawing.Point(12, 586);
            this.labelTaux.Name = "labelTaux";
            this.labelTaux.Size = new System.Drawing.Size(93, 20);
            this.labelTaux.TabIndex = 19;
            this.labelTaux.Text = "Taux (en %) :";
            // 
            // labelTauxMens
            // 
            this.labelTauxMens.AutoSize = true;
            this.labelTauxMens.Location = new System.Drawing.Point(10, 621);
            this.labelTauxMens.Name = "labelTauxMens";
            this.labelTauxMens.Size = new System.Drawing.Size(147, 20);
            this.labelTauxMens.TabIndex = 20;
            this.labelTauxMens.Text = "Nombre mensualité :";
            // 
            // labelMontantMens
            // 
            this.labelMontantMens.AutoSize = true;
            this.labelMontantMens.Location = new System.Drawing.Point(76, 683);
            this.labelMontantMens.Name = "labelMontantMens";
            this.labelMontantMens.Size = new System.Drawing.Size(148, 20);
            this.labelMontantMens.TabIndex = 21;
            this.labelMontantMens.Text = "Montant mensualité :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 748);
            this.Controls.Add(this.labelMontantMens);
            this.Controls.Add(this.labelTauxMens);
            this.Controls.Add(this.labelTaux);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.buttonCalculMens);
            this.Controls.Add(this.textBoxNbMens);
            this.Controls.Add(this.textBoxTaux);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.labelMensualite);
            this.Controls.Add(this.textBoxSeuil);
            this.Controls.Add(this.labelSeuil);
            this.Controls.Add(this.labelMoyenne);
            this.Controls.Add(this.labelMinMax);
            this.Controls.Add(this.buttonLissagex3);
            this.Controls.Add(this.buttonBinarisation);
            this.Controls.Add(this.buttonMoyenne);
            this.Controls.Add(this.buttonMinMax);
            this.Controls.Add(this.buttonAffAlea);
            this.Controls.Add(this.buttonAffich);
            this.Controls.Add(this.buttonEffacer);
            this.Controls.Add(this.listBoxTableau);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "José";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTableau;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.Button buttonAffich;
        private System.Windows.Forms.Button buttonAffAlea;
        private System.Windows.Forms.Button buttonMinMax;
        private System.Windows.Forms.Button buttonMoyenne;
        private System.Windows.Forms.Button buttonBinarisation;
        private System.Windows.Forms.Button buttonLissagex3;
        private System.Windows.Forms.Label labelMinMax;
        private System.Windows.Forms.Label labelMoyenne;
        private System.Windows.Forms.Label labelSeuil;
        private System.Windows.Forms.TextBox textBoxSeuil;
        private System.Windows.Forms.Label labelMensualite;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.TextBox textBoxTaux;
        private System.Windows.Forms.TextBox textBoxNbMens;
        private System.Windows.Forms.Button buttonCalculMens;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelTaux;
        private System.Windows.Forms.Label labelTauxMens;
        private System.Windows.Forms.Label labelMontantMens;
    }
}

