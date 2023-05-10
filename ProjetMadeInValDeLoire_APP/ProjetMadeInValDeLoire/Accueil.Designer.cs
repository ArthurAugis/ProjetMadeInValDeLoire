namespace ProjetMadeInValDeLoire
{
    partial class Accueil
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
            this.regle = new System.Windows.Forms.Button();
            this.commencer = new System.Windows.Forms.Button();
            this.connecter = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regle
            // 
            this.regle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.regle.Location = new System.Drawing.Point(258, 118);
            this.regle.Name = "regle";
            this.regle.Size = new System.Drawing.Size(291, 36);
            this.regle.TabIndex = 0;
            this.regle.Text = "Regles";
            this.regle.UseVisualStyleBackColor = true;
            this.regle.Click += new System.EventHandler(this.regle_Click);
            // 
            // commencer
            // 
            this.commencer.Location = new System.Drawing.Point(258, 172);
            this.commencer.Name = "commencer";
            this.commencer.Size = new System.Drawing.Size(291, 36);
            this.commencer.TabIndex = 1;
            this.commencer.Text = "Commencer";
            this.commencer.UseVisualStyleBackColor = true;
            this.commencer.Click += new System.EventHandler(this.commencer_Click);
            // 
            // connecter
            // 
            this.connecter.Location = new System.Drawing.Point(258, 225);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(291, 36);
            this.connecter.TabIndex = 2;
            this.connecter.Text = "Se connecter/S\'inscrire";
            this.connecter.UseVisualStyleBackColor = true;
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(348, 61);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(122, 25);
            this.titre.TabIndex = 3;
            this.titre.Text = "CyberQuiz";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.commencer);
            this.Controls.Add(this.regle);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regle;
        private System.Windows.Forms.Button commencer;
        private System.Windows.Forms.Button connecter;
        private System.Windows.Forms.Label titre;
    }
}

