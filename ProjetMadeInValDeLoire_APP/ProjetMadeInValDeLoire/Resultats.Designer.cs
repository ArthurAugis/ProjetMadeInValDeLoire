﻿namespace ProjetMadeInValDeLoire
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsPre = new System.Windows.Forms.TextBox();
            this.inscrire = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsMdp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInsIden = new System.Windows.Forms.TextBox();
            this.connecter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitre
            // 
            this.txtTitre.AutoSize = true;
            this.txtTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(278, 20);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(237, 29);
            this.txtTitre.TabIndex = 0;
            this.txtTitre.Text = "Voici ton score : 69%";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(88, 166);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(194, 32);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer mon résultat";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(88, 205);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(194, 32);
            this.btnAccueil.TabIndex = 4;
            this.btnAccueil.Text = "Revenir à l\'accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(104, 230);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 47;
            this.button1.Text = "👁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.voirMDP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nom";
            // 
            // txtInsNom
            // 
            this.txtInsNom.Location = new System.Drawing.Point(491, 125);
            this.txtInsNom.Name = "txtInsNom";
            this.txtInsNom.Size = new System.Drawing.Size(154, 20);
            this.txtInsNom.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Prénom";
            // 
            // txtInsPre
            // 
            this.txtInsPre.Location = new System.Drawing.Point(491, 173);
            this.txtInsPre.Name = "txtInsPre";
            this.txtInsPre.Size = new System.Drawing.Size(154, 20);
            this.txtInsPre.TabIndex = 43;
            // 
            // inscrire
            // 
            this.inscrire.Location = new System.Drawing.Point(579, 317);
            this.inscrire.Name = "inscrire";
            this.inscrire.Size = new System.Drawing.Size(66, 23);
            this.inscrire.TabIndex = 41;
            this.inscrire.Text = "S\'inscrire";
            this.inscrire.UseVisualStyleBackColor = true;
            this.inscrire.Click += new System.EventHandler(this.inscrire_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(488, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Mot de passe";
            // 
            // txtInsMdp
            // 
            this.txtInsMdp.Location = new System.Drawing.Point(491, 280);
            this.txtInsMdp.Name = "txtInsMdp";
            this.txtInsMdp.Size = new System.Drawing.Size(154, 20);
            this.txtInsMdp.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Identifiant";
            // 
            // txtInsIden
            // 
            this.txtInsIden.Location = new System.Drawing.Point(491, 226);
            this.txtInsIden.Name = "txtInsIden";
            this.txtInsIden.Size = new System.Drawing.Size(154, 20);
            this.txtInsIden.TabIndex = 37;
            // 
            // connecter
            // 
            this.connecter.Location = new System.Drawing.Point(491, 317);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(86, 23);
            this.connecter.TabIndex = 49;
            this.connecter.Text = "Se connecter";
            this.connecter.UseVisualStyleBackColor = true;
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(388, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Connecte toi si tu veux enregistrer ton score";
            // 
            // Resultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.message);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsPre);
            this.Controls.Add(this.inscrire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInsMdp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInsIden);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtTitre);
            this.Name = "Resultats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitre;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsPre;
        private System.Windows.Forms.Button inscrire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsMdp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInsIden;
        private System.Windows.Forms.Button connecter;
        private System.Windows.Forms.Label label3;
    }
}