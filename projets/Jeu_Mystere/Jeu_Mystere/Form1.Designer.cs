namespace Jeu_Mystere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.essais = new System.Windows.Forms.Label();
            this.pourcentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(322, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jouer !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(292, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 33);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(255, 334);
            this.label1.MinimumSize = new System.Drawing.Size(300, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(300, 39);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(210, 72);
            this.label2.MinimumSize = new System.Drawing.Size(200, 2);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(408, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tapez un nombre entre 1 et 100 pour trouver le nombre mystère";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(255, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 32);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // essais
            // 
            this.essais.AutoSize = true;
            this.essais.BackColor = System.Drawing.SystemColors.Info;
            this.essais.Location = new System.Drawing.Point(21, 196);
            this.essais.MinimumSize = new System.Drawing.Size(200, 2);
            this.essais.Name = "essais";
            this.essais.Padding = new System.Windows.Forms.Padding(10);
            this.essais.Size = new System.Drawing.Size(200, 37);
            this.essais.TabIndex = 5;
            this.essais.Text = "Essais n° 1";
            // 
            // pourcentage
            // 
            this.pourcentage.AutoSize = true;
            this.pourcentage.BackColor = System.Drawing.SystemColors.Info;
            this.pourcentage.Location = new System.Drawing.Point(12, 418);
            this.pourcentage.MinimumSize = new System.Drawing.Size(200, 2);
            this.pourcentage.Name = "pourcentage";
            this.pourcentage.Padding = new System.Windows.Forms.Padding(10);
            this.pourcentage.Size = new System.Drawing.Size(200, 37);
            this.pourcentage.TabIndex = 6;
            this.pourcentage.Text = "Proximité";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 507);
            this.Controls.Add(this.pourcentage);
            this.Controls.Add(this.essais);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label essais;
        private System.Windows.Forms.Label pourcentage;
    }
}

