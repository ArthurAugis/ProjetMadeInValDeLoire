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
            this.difficulte3 = new System.Windows.Forms.Button();
            this.difficulte2 = new System.Windows.Forms.Button();
            this.difficulte1 = new System.Windows.Forms.Button();
            this.difficulte4 = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficulte3
            // 
            this.difficulte3.BackColor = System.Drawing.Color.Transparent;
            this.difficulte3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.difficulte3.Location = new System.Drawing.Point(216, 275);
            this.difficulte3.Name = "difficulte3";
            this.difficulte3.Size = new System.Drawing.Size(363, 74);
            this.difficulte3.TabIndex = 6;
            this.difficulte3.UseVisualStyleBackColor = false;
            this.difficulte3.Click += new System.EventHandler(this.difficulte3_Click);
            // 
            // difficulte2
            // 
            this.difficulte2.BackColor = System.Drawing.Color.Transparent;
            this.difficulte2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.difficulte2.Location = new System.Drawing.Point(210, 198);
            this.difficulte2.Name = "difficulte2";
            this.difficulte2.Size = new System.Drawing.Size(369, 71);
            this.difficulte2.TabIndex = 5;
            this.difficulte2.UseVisualStyleBackColor = false;
            this.difficulte2.Click += new System.EventHandler(this.difficulte2_Click);
            // 
            // difficulte1
            // 
            this.difficulte1.BackColor = System.Drawing.Color.Transparent;
            this.difficulte1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.difficulte1.Location = new System.Drawing.Point(210, 119);
            this.difficulte1.Name = "difficulte1";
            this.difficulte1.Size = new System.Drawing.Size(369, 73);
            this.difficulte1.TabIndex = 4;
            this.difficulte1.UseVisualStyleBackColor = false;
            this.difficulte1.Click += new System.EventHandler(this.difficulte1_Click);
            // 
            // difficulte4
            // 
            this.difficulte4.BackColor = System.Drawing.Color.Transparent;
            this.difficulte4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.difficulte4.Location = new System.Drawing.Point(216, 355);
            this.difficulte4.Name = "difficulte4";
            this.difficulte4.Size = new System.Drawing.Size(363, 71);
            this.difficulte4.TabIndex = 8;
            this.difficulte4.UseVisualStyleBackColor = false;
            this.difficulte4.Click += new System.EventHandler(this.difficulte4_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Location = new System.Drawing.Point(12, 390);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(141, 48);
            this.btnRetour.TabIndex = 9;
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Commencer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetMadeInValDeLoire.Properties.Resources.difficlute;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.difficulte4);
            this.Controls.Add(this.difficulte3);
            this.Controls.Add(this.difficulte2);
            this.Controls.Add(this.difficulte1);
            this.DoubleBuffered = true;
            this.Name = "Commencer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commencer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button difficulte3;
        private System.Windows.Forms.Button difficulte2;
        private System.Windows.Forms.Button difficulte1;
        private System.Windows.Forms.Button difficulte4;
        private System.Windows.Forms.Button btnRetour;
    }
}