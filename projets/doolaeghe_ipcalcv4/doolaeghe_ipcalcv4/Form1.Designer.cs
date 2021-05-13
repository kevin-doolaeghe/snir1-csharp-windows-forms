namespace doolaeghe_ipcalcv4
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
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdresseReseau = new System.Windows.Forms.Label();
            this.labelBroadcast = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMasque = new System.Windows.Forms.ComboBox();
            this.textBoxIP1 = new System.Windows.Forms.TextBox();
            this.textBoxIP2 = new System.Windows.Forms.TextBox();
            this.textBoxIP3 = new System.Windows.Forms.TextBox();
            this.textBoxIP4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(319, 129);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(106, 38);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Calculer";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresse Réseau :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse de broadcast :";
            // 
            // labelAdresseReseau
            // 
            this.labelAdresseReseau.AutoSize = true;
            this.labelAdresseReseau.Location = new System.Drawing.Point(223, 212);
            this.labelAdresseReseau.Name = "labelAdresseReseau";
            this.labelAdresseReseau.Size = new System.Drawing.Size(0, 15);
            this.labelAdresseReseau.TabIndex = 4;
            // 
            // labelBroadcast
            // 
            this.labelBroadcast.AutoSize = true;
            this.labelBroadcast.Location = new System.Drawing.Point(223, 227);
            this.labelBroadcast.Name = "labelBroadcast";
            this.labelBroadcast.Size = new System.Drawing.Size(0, 15);
            this.labelBroadcast.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "@IP :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "/";
            // 
            // comboBoxMasque
            // 
            this.comboBoxMasque.DropDownHeight = 90;
            this.comboBoxMasque.FormattingEnabled = true;
            this.comboBoxMasque.IntegralHeight = false;
            this.comboBoxMasque.ItemHeight = 15;
            this.comboBoxMasque.Location = new System.Drawing.Point(374, 76);
            this.comboBoxMasque.MaxLength = 2;
            this.comboBoxMasque.Name = "comboBoxMasque";
            this.comboBoxMasque.Size = new System.Drawing.Size(51, 23);
            this.comboBoxMasque.TabIndex = 11;
            // 
            // textBoxIP1
            // 
            this.textBoxIP1.Location = new System.Drawing.Point(108, 76);
            this.textBoxIP1.Name = "textBoxIP1";
            this.textBoxIP1.Size = new System.Drawing.Size(34, 23);
            this.textBoxIP1.TabIndex = 12;
            this.textBoxIP1.Text = "192";
            // 
            // textBoxIP2
            // 
            this.textBoxIP2.Location = new System.Drawing.Point(164, 76);
            this.textBoxIP2.Name = "textBoxIP2";
            this.textBoxIP2.Size = new System.Drawing.Size(34, 23);
            this.textBoxIP2.TabIndex = 13;
            this.textBoxIP2.Text = "168";
            // 
            // textBoxIP3
            // 
            this.textBoxIP3.Location = new System.Drawing.Point(220, 76);
            this.textBoxIP3.Name = "textBoxIP3";
            this.textBoxIP3.Size = new System.Drawing.Size(34, 23);
            this.textBoxIP3.TabIndex = 14;
            this.textBoxIP3.Text = "0";
            // 
            // textBoxIP4
            // 
            this.textBoxIP4.Location = new System.Drawing.Point(276, 76);
            this.textBoxIP4.Name = "textBoxIP4";
            this.textBoxIP4.Size = new System.Drawing.Size(34, 23);
            this.textBoxIP4.TabIndex = 15;
            this.textBoxIP4.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 327);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxIP4);
            this.Controls.Add(this.textBoxIP3);
            this.Controls.Add(this.textBoxIP2);
            this.Controls.Add(this.textBoxIP1);
            this.Controls.Add(this.comboBoxMasque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelBroadcast);
            this.Controls.Add(this.labelAdresseReseau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalc);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IP Calc v4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdresseReseau;
        private System.Windows.Forms.Label labelBroadcast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMasque;
        private System.Windows.Forms.TextBox textBoxIP1;
        private System.Windows.Forms.TextBox textBoxIP2;
        private System.Windows.Forms.TextBox textBoxIP3;
        private System.Windows.Forms.TextBox textBoxIP4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

