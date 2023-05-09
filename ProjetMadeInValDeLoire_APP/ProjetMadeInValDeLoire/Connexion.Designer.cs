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
            this.btnConnecter = new System.Windows.Forms.Button();
            this.inscrire = new System.Windows.Forms.Button();
            this.lblMdp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(393, 278);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(86, 23);
            this.btnConnecter.TabIndex = 15;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // inscrire
            // 
            this.inscrire.Location = new System.Drawing.Point(325, 278);
            this.inscrire.Name = "inscrire";
            this.inscrire.Size = new System.Drawing.Size(66, 23);
            this.inscrire.TabIndex = 14;
            this.inscrire.Text = "S\'inscrire";
            this.inscrire.UseVisualStyleBackColor = true;
            this.inscrire.Click += new System.EventHandler(this.inscrire_Click);
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(322, 204);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(98, 18);
            this.lblMdp.TabIndex = 13;
            this.lblMdp.Text = "Mot de passe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 12;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(322, 150);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(69, 18);
            this.lblIdentifiant.TabIndex = 11;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(325, 171);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(154, 20);
            this.txtIdentifiant.TabIndex = 10;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(322, 317);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 16;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.inscrire);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.txtIdentifiant);
            this.Name = "Connexion";
            this.Text = "Se connecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Button inscrire;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblMessage;
    }
}