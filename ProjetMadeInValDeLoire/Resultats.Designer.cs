namespace ProjetMadeInValDeLoire
{
    partial class Resultats
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
            this.txtTitre = new System.Windows.Forms.Label();
            this.txtPourcent = new System.Windows.Forms.Label();
            this.btnExplications = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitre
            // 
            this.txtTitre.AutoSize = true;
            this.txtTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(295, 43);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(212, 29);
            this.txtTitre.TabIndex = 0;
            this.txtTitre.Text = "Voici tes résultats :";
            // 
            // txtPourcent
            // 
            this.txtPourcent.AutoSize = true;
            this.txtPourcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPourcent.Location = new System.Drawing.Point(369, 82);
            this.txtPourcent.Name = "txtPourcent";
            this.txtPourcent.Size = new System.Drawing.Size(61, 29);
            this.txtPourcent.TabIndex = 1;
            this.txtPourcent.Text = "69%";
            // 
            // btnExplications
            // 
            this.btnExplications.Location = new System.Drawing.Point(300, 131);
            this.btnExplications.Name = "btnExplications";
            this.btnExplications.Size = new System.Drawing.Size(194, 32);
            this.btnExplications.TabIndex = 2;
            this.btnExplications.Text = "Voir les explications";
            this.btnExplications.UseVisualStyleBackColor = true;
            this.btnExplications.Click += new System.EventHandler(this.btnExplications_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(300, 178);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(194, 32);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer mon résultat";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(300, 226);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(194, 32);
            this.btnAccueil.TabIndex = 4;
            this.btnAccueil.Text = "Revenir à l\'accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // Resultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnExplications);
            this.Controls.Add(this.txtPourcent);
            this.Controls.Add(this.txtTitre);
            this.Name = "Resultats";
            this.Text = "Resultats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitre;
        private System.Windows.Forms.Label txtPourcent;
        private System.Windows.Forms.Button btnExplications;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAccueil;
    }
}