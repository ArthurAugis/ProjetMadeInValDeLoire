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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regle
            // 
            this.regle.BackColor = System.Drawing.Color.Transparent;
            this.regle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regle.ForeColor = System.Drawing.Color.Snow;
            this.regle.Location = new System.Drawing.Point(264, 155);
            this.regle.Name = "regle";
            this.regle.Size = new System.Drawing.Size(299, 72);
            this.regle.TabIndex = 0;
            this.regle.UseVisualStyleBackColor = false;
            this.regle.Click += new System.EventHandler(this.regle_Click);
            // 
            // commencer
            // 
            this.commencer.BackColor = System.Drawing.Color.Transparent;
            this.commencer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commencer.Location = new System.Drawing.Point(264, 233);
            this.commencer.Name = "commencer";
            this.commencer.Size = new System.Drawing.Size(299, 67);
            this.commencer.TabIndex = 1;
            this.commencer.UseVisualStyleBackColor = false;
            this.commencer.Click += new System.EventHandler(this.commencer_Click);
            // 
            // connecter
            // 
            this.connecter.BackColor = System.Drawing.Color.Transparent;
            this.connecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connecter.ForeColor = System.Drawing.Color.Transparent;
            this.connecter.Location = new System.Drawing.Point(264, 306);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(299, 67);
            this.connecter.TabIndex = 2;
            this.connecter.UseVisualStyleBackColor = false;
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(24, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 50);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetMadeInValDeLoire.Properties.Resources.acceuil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.commencer);
            this.Controls.Add(this.regle);
            this.DoubleBuffered = true;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regle;
        private System.Windows.Forms.Button commencer;
        private System.Windows.Forms.Button connecter;
        private System.Windows.Forms.Button button1;
    }
}

