namespace ProjetMadeInValDeLoire
{
    partial class Connexion
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
            this.connecter = new System.Windows.Forms.Button();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtConnMdp = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtConnIden = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.voirLeMdp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsPre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inscrire = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsMdp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInsIden = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connecter
            // 
            this.connecter.BackColor = System.Drawing.Color.Transparent;
            this.connecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connecter.Location = new System.Drawing.Point(515, 338);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(151, 38);
            this.connecter.TabIndex = 15;
            this.connecter.UseVisualStyleBackColor = false;
            this.connecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.BackColor = System.Drawing.Color.Transparent;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(497, 217);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(98, 18);
            this.lblMdp.TabIndex = 13;
            this.lblMdp.Text = "Mot de passe";
            // 
            // txtConnMdp
            // 
            this.txtConnMdp.Location = new System.Drawing.Point(500, 238);
            this.txtConnMdp.Name = "txtConnMdp";
            this.txtConnMdp.Size = new System.Drawing.Size(154, 20);
            this.txtConnMdp.TabIndex = 12;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(497, 163);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(69, 18);
            this.lblIdentifiant.TabIndex = 11;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // txtConnIden
            // 
            this.txtConnIden.Location = new System.Drawing.Point(500, 184);
            this.txtConnIden.Name = "txtConnIden";
            this.txtConnIden.Size = new System.Drawing.Size(154, 20);
            this.txtConnIden.TabIndex = 10;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(308, 343);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 16;
            // 
            // voirLeMdp
            // 
            this.voirLeMdp.Location = new System.Drawing.Point(660, 238);
            this.voirLeMdp.Name = "voirLeMdp";
            this.voirLeMdp.Size = new System.Drawing.Size(24, 20);
            this.voirLeMdp.TabIndex = 22;
            this.voirLeMdp.Text = "👁";
            this.voirLeMdp.UseVisualStyleBackColor = true;
            this.voirLeMdp.Click += new System.EventHandler(this.voirPass);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 34;
            this.button1.Text = "👁";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.voirMDP);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nom";
            // 
            // txtInsNom
            // 
            this.txtInsNom.Location = new System.Drawing.Point(154, 139);
            this.txtInsNom.Name = "txtInsNom";
            this.txtInsNom.Size = new System.Drawing.Size(154, 20);
            this.txtInsNom.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Prénom";
            // 
            // txtInsPre
            // 
            this.txtInsPre.Location = new System.Drawing.Point(154, 187);
            this.txtInsPre.Name = "txtInsPre";
            this.txtInsPre.Size = new System.Drawing.Size(154, 20);
            this.txtInsPre.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 29;
            // 
            // inscrire
            // 
            this.inscrire.BackColor = System.Drawing.Color.Transparent;
            this.inscrire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inscrire.Location = new System.Drawing.Point(169, 338);
            this.inscrire.Name = "inscrire";
            this.inscrire.Size = new System.Drawing.Size(152, 38);
            this.inscrire.TabIndex = 27;
            this.inscrire.UseVisualStyleBackColor = false;
            this.inscrire.Click += new System.EventHandler(this.inscrire_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mot de passe";
            // 
            // txtInsMdp
            // 
            this.txtInsMdp.Location = new System.Drawing.Point(154, 294);
            this.txtInsMdp.Name = "txtInsMdp";
            this.txtInsMdp.Size = new System.Drawing.Size(154, 20);
            this.txtInsMdp.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Identifiant";
            // 
            // txtInsIden
            // 
            this.txtInsIden.Location = new System.Drawing.Point(154, 240);
            this.txtInsIden.Name = "txtInsIden";
            this.txtInsIden.Size = new System.Drawing.Size(154, 20);
            this.txtInsIden.TabIndex = 23;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(314, 348);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 35;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Location = new System.Drawing.Point(12, 399);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(111, 39);
            this.btnRetour.TabIndex = 36;
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetMadeInValDeLoire.Properties.Resources.connexion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.message);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsPre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inscrire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInsMdp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInsIden);
            this.Controls.Add(this.voirLeMdp);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txtConnMdp);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.txtConnIden);
            this.DoubleBuffered = true;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Se connecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connecter;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtConnMdp;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtConnIden;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button voirLeMdp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsPre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inscrire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsMdp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInsIden;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button btnRetour;
    }
}