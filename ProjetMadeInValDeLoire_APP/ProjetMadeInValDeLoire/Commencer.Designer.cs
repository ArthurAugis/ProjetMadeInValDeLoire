namespace ProjetMadeInValDeLoire
{
    partial class Commencer
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
            this.titre = new System.Windows.Forms.Label();
            this.difficulte3 = new System.Windows.Forms.Button();
            this.difficulte2 = new System.Windows.Forms.Button();
            this.difficulte1 = new System.Windows.Forms.Button();
            this.difficulte4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(273, 43);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(262, 25);
            this.titre.TabIndex = 7;
            this.titre.Text = "Choississez la difficulté";
            // 
            // difficulte3
            // 
            this.difficulte3.Location = new System.Drawing.Point(258, 211);
            this.difficulte3.Name = "difficulte3";
            this.difficulte3.Size = new System.Drawing.Size(291, 36);
            this.difficulte3.TabIndex = 6;
            this.difficulte3.Text = "Etudiants";
            this.difficulte3.UseVisualStyleBackColor = true;
            this.difficulte3.Click += new System.EventHandler(this.difficulte3_Click);
            // 
            // difficulte2
            // 
            this.difficulte2.Location = new System.Drawing.Point(258, 158);
            this.difficulte2.Name = "difficulte2";
            this.difficulte2.Size = new System.Drawing.Size(291, 36);
            this.difficulte2.TabIndex = 5;
            this.difficulte2.Text = "Lycéens";
            this.difficulte2.UseVisualStyleBackColor = true;
            this.difficulte2.Click += new System.EventHandler(this.difficulte2_Click);
            // 
            // difficulte1
            // 
            this.difficulte1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.difficulte1.Location = new System.Drawing.Point(258, 104);
            this.difficulte1.Name = "difficulte1";
            this.difficulte1.Size = new System.Drawing.Size(291, 36);
            this.difficulte1.TabIndex = 4;
            this.difficulte1.Text = "Collégiens";
            this.difficulte1.UseVisualStyleBackColor = true;
            this.difficulte1.Click += new System.EventHandler(this.difficulte1_Click);
            // 
            // difficulte4
            // 
            this.difficulte4.Location = new System.Drawing.Point(258, 263);
            this.difficulte4.Name = "difficulte4";
            this.difficulte4.Size = new System.Drawing.Size(291, 36);
            this.difficulte4.TabIndex = 8;
            this.difficulte4.Text = "Professionnels";
            this.difficulte4.UseVisualStyleBackColor = true;
            this.difficulte4.Click += new System.EventHandler(this.difficulte4_Click);
            // 
            // Commencer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.difficulte4);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.difficulte3);
            this.Controls.Add(this.difficulte2);
            this.Controls.Add(this.difficulte1);
            this.Name = "Commencer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commencer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button difficulte3;
        private System.Windows.Forms.Button difficulte2;
        private System.Windows.Forms.Button difficulte1;
        private System.Windows.Forms.Button difficulte4;
    }
}