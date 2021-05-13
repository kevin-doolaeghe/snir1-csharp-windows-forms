namespace Equation2ndDeg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coef_reel = new System.Windows.Forms.TextBox();
            this.coef_x = new System.Windows.Forms.TextBox();
            this.coef_x2 = new System.Windows.Forms.TextBox();
            this.BtValid = new System.Windows.Forms.Button();
            this.LabelNbSol = new System.Windows.Forms.Label();
            this.LabelSolX1 = new System.Windows.Forms.Label();
            this.LabelSolX2 = new System.Windows.Forms.Label();
            this.radioButtonReel = new System.Windows.Forms.RadioButton();
            this.radioButtonComplexe = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "x² +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "x +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "= 0";
            // 
            // coef_reel
            // 
            this.coef_reel.BackColor = System.Drawing.SystemColors.Window;
            this.coef_reel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coef_reel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coef_reel.Location = new System.Drawing.Point(286, 77);
            this.coef_reel.Name = "coef_reel";
            this.coef_reel.Size = new System.Drawing.Size(69, 29);
            this.coef_reel.TabIndex = 5;
            // 
            // coef_x
            // 
            this.coef_x.BackColor = System.Drawing.SystemColors.Window;
            this.coef_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coef_x.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coef_x.Location = new System.Drawing.Point(174, 77);
            this.coef_x.Name = "coef_x";
            this.coef_x.Size = new System.Drawing.Size(69, 29);
            this.coef_x.TabIndex = 6;
            // 
            // coef_x2
            // 
            this.coef_x2.BackColor = System.Drawing.SystemColors.Window;
            this.coef_x2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coef_x2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coef_x2.Location = new System.Drawing.Point(56, 77);
            this.coef_x2.Name = "coef_x2";
            this.coef_x2.Size = new System.Drawing.Size(69, 29);
            this.coef_x2.TabIndex = 7;
            // 
            // BtValid
            // 
            this.BtValid.BackColor = System.Drawing.SystemColors.Control;
            this.BtValid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtValid.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtValid.Location = new System.Drawing.Point(162, 180);
            this.BtValid.Name = "BtValid";
            this.BtValid.Size = new System.Drawing.Size(106, 37);
            this.BtValid.TabIndex = 8;
            this.BtValid.Text = "Résoudre";
            this.BtValid.UseVisualStyleBackColor = false;
            this.BtValid.Click += new System.EventHandler(this.BtValid_Click);
            // 
            // LabelNbSol
            // 
            this.LabelNbSol.AutoSize = true;
            this.LabelNbSol.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNbSol.Location = new System.Drawing.Point(109, 245);
            this.LabelNbSol.Name = "LabelNbSol";
            this.LabelNbSol.Size = new System.Drawing.Size(0, 22);
            this.LabelNbSol.TabIndex = 9;
            // 
            // LabelSolX1
            // 
            this.LabelSolX1.AutoSize = true;
            this.LabelSolX1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSolX1.Location = new System.Drawing.Point(52, 300);
            this.LabelSolX1.Name = "LabelSolX1";
            this.LabelSolX1.Size = new System.Drawing.Size(0, 22);
            this.LabelSolX1.TabIndex = 10;
            // 
            // LabelSolX2
            // 
            this.LabelSolX2.AutoSize = true;
            this.LabelSolX2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSolX2.Location = new System.Drawing.Point(52, 360);
            this.LabelSolX2.Name = "LabelSolX2";
            this.LabelSolX2.Size = new System.Drawing.Size(0, 22);
            this.LabelSolX2.TabIndex = 11;
            // 
            // radioButtonReel
            // 
            this.radioButtonReel.AutoSize = true;
            this.radioButtonReel.Checked = true;
            this.radioButtonReel.Location = new System.Drawing.Point(426, 146);
            this.radioButtonReel.Name = "radioButtonReel";
            this.radioButtonReel.Size = new System.Drawing.Size(110, 19);
            this.radioButtonReel.TabIndex = 12;
            this.radioButtonReel.TabStop = true;
            this.radioButtonReel.Text = "Solutions réelles";
            this.radioButtonReel.UseVisualStyleBackColor = true;
            // 
            // radioButtonComplexe
            // 
            this.radioButtonComplexe.AutoSize = true;
            this.radioButtonComplexe.Location = new System.Drawing.Point(426, 180);
            this.radioButtonComplexe.Name = "radioButtonComplexe";
            this.radioButtonComplexe.Size = new System.Drawing.Size(132, 19);
            this.radioButtonComplexe.TabIndex = 13;
            this.radioButtonComplexe.Text = "Solutions complexes";
            this.radioButtonComplexe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(633, 479);
            this.Controls.Add(this.radioButtonComplexe);
            this.Controls.Add(this.radioButtonReel);
            this.Controls.Add(this.LabelSolX2);
            this.Controls.Add(this.LabelSolX1);
            this.Controls.Add(this.LabelNbSol);
            this.Controls.Add(this.BtValid);
            this.Controls.Add(this.coef_x2);
            this.Controls.Add(this.coef_x);
            this.Controls.Add(this.coef_reel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox coef_reel;
        private System.Windows.Forms.TextBox coef_x;
        private System.Windows.Forms.TextBox coef_x2;
        private System.Windows.Forms.Button BtValid;
        private System.Windows.Forms.Label LabelNbSol;
        private System.Windows.Forms.Label LabelSolX1;
        private System.Windows.Forms.Label LabelSolX2;
        private System.Windows.Forms.RadioButton radioButtonReel;
        private System.Windows.Forms.RadioButton radioButtonComplexe;
    }
}

