namespace ProjetMadeInValDeLoire
{
    partial class Explications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtNbrQuestion = new System.Windows.Forms.Label();
            this.lblreponse1 = new System.Windows.Forms.Label();
            this.lblCorrection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(324, 37);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(125, 29);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Correction";
            // 
            // txtNbrQuestion
            // 
            this.txtNbrQuestion.AutoSize = true;
            this.txtNbrQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbrQuestion.Location = new System.Drawing.Point(12, 89);
            this.txtNbrQuestion.Name = "txtNbrQuestion";
            this.txtNbrQuestion.Size = new System.Drawing.Size(249, 20);
            this.txtNbrQuestion.TabIndex = 1;
            this.txtNbrQuestion.Text = "Question 1 : Qu\'est-ce que la vie ?";
            // 
            // lblreponse1
            // 
            this.lblreponse1.AutoSize = true;
            this.lblreponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreponse1.ForeColor = System.Drawing.Color.Tomato;
            this.lblreponse1.Location = new System.Drawing.Point(12, 109);
            this.lblreponse1.Name = "lblreponse1";
            this.lblreponse1.Size = new System.Drawing.Size(34, 16);
            this.lblreponse1.TabIndex = 2;
            this.lblreponse1.Text = "Feur";
            // 
            // lblCorrection
            // 
            this.lblCorrection.AutoSize = true;
            this.lblCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrection.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblCorrection.Location = new System.Drawing.Point(13, 125);
            this.lblCorrection.Name = "lblCorrection";
            this.lblCorrection.Size = new System.Drawing.Size(21, 16);
            this.lblCorrection.TabIndex = 3;
            this.lblCorrection.Text = "42";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "42";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Question 2 : Qu\'est-ce que la vie v2 ?";
            // 
            // btnAccueil
            // 
            this.btnAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.Location = new System.Drawing.Point(315, 399);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(144, 28);
            this.btnAccueil.TabIndex = 6;
            this.btnAccueil.Text = "Revenir à l\'accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            // 
            // Explications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCorrection);
            this.Controls.Add(this.lblreponse1);
            this.Controls.Add(this.txtNbrQuestion);
            this.Controls.Add(this.lblTitre);
            this.Name = "Explications";
            this.Text = "Explications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label txtNbrQuestion;
        private System.Windows.Forms.Label lblreponse1;
        private System.Windows.Forms.Label lblCorrection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccueil;
    }
}