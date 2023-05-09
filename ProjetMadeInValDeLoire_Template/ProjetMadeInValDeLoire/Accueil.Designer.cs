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
            this.difficulte1 = new System.Windows.Forms.Button();
            this.difficulte2 = new System.Windows.Forms.Button();
            this.difficulte3 = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connexion = new System.Windows.Forms.Button();
            this.inscrire = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficulte1
            // 
            this.difficulte1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.difficulte1.Location = new System.Drawing.Point(422, 126);
            this.difficulte1.Name = "difficulte1";
            this.difficulte1.Size = new System.Drawing.Size(291, 36);
            this.difficulte1.TabIndex = 0;
            this.difficulte1.Text = "Collégiens";
            this.difficulte1.UseVisualStyleBackColor = true;
            // 
            // difficulte2
            // 
            this.difficulte2.Location = new System.Drawing.Point(422, 180);
            this.difficulte2.Name = "difficulte2";
            this.difficulte2.Size = new System.Drawing.Size(291, 36);
            this.difficulte2.TabIndex = 1;
            this.difficulte2.Text = "Lycéens";
            this.difficulte2.UseVisualStyleBackColor = true;
            // 
            // difficulte3
            // 
            this.difficulte3.Location = new System.Drawing.Point(422, 233);
            this.difficulte3.Name = "difficulte3";
            this.difficulte3.Size = new System.Drawing.Size(291, 36);
            this.difficulte3.TabIndex = 2;
            this.difficulte3.Text = "Etudiants";
            this.difficulte3.UseVisualStyleBackColor = true;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(512, 69);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(122, 25);
            this.titre.TabIndex = 3;
            this.titre.Text = "CyberQuiz";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(76, 126);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(154, 20);
            this.txtIdentifiant.TabIndex = 4;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(73, 105);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(69, 18);
            this.lblIdentifiant.TabIndex = 5;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(73, 159);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(98, 18);
            this.lblMdp.TabIndex = 7;
            this.lblMdp.Text = "Mot de passe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 6;
            // 
            // connexion
            // 
            this.connexion.Location = new System.Drawing.Point(144, 233);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(86, 23);
            this.connexion.TabIndex = 9;
            this.connexion.Text = "Se connecter";
            this.connexion.UseVisualStyleBackColor = true;
            // 
            // inscrire
            // 
            this.inscrire.Location = new System.Drawing.Point(76, 233);
            this.inscrire.Name = "inscrire";
            this.inscrire.Size = new System.Drawing.Size(66, 23);
            this.inscrire.TabIndex = 8;
            this.inscrire.Text = "S\'inscrire";
            this.inscrire.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Professionnels";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connexion);
            this.Controls.Add(this.inscrire);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.difficulte3);
            this.Controls.Add(this.difficulte2);
            this.Controls.Add(this.difficulte1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button difficulte1;
        private System.Windows.Forms.Button difficulte2;
        private System.Windows.Forms.Button difficulte3;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button connexion;
        private System.Windows.Forms.Button inscrire;
        private System.Windows.Forms.Button button1;
    }
}

