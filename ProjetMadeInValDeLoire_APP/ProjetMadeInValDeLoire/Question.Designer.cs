namespace ProjetMadeInValDeLoire
{
    partial class Question
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.reponse1 = new System.Windows.Forms.Button();
            this.difficulte = new System.Windows.Forms.Label();
            this.lblNbrQuestions = new System.Windows.Forms.Label();
            this.reponse2 = new System.Windows.Forms.Button();
            this.reponse3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(153, 117);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(199, 29);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "C\'est quoi la vie ?";
            // 
            // reponse1
            // 
            this.reponse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse1.Location = new System.Drawing.Point(72, 190);
            this.reponse1.Name = "reponse1";
            this.reponse1.Size = new System.Drawing.Size(334, 65);
            this.reponse1.TabIndex = 1;
            this.reponse1.UseVisualStyleBackColor = true;
            this.reponse1.Click += new System.EventHandler(this.reponse1_Click);
            // 
            // difficulte
            // 
            this.difficulte.AutoSize = true;
            this.difficulte.BackColor = System.Drawing.Color.Transparent;
            this.difficulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.difficulte.Location = new System.Drawing.Point(228, 20);
            this.difficulte.Name = "difficulte";
            this.difficulte.Size = new System.Drawing.Size(94, 24);
            this.difficulte.TabIndex = 9;
            this.difficulte.Text = "Difficulté : ";
            this.difficulte.Click += new System.EventHandler(this.difficulte_Click);
            // 
            // lblNbrQuestions
            // 
            this.lblNbrQuestions.AutoSize = true;
            this.lblNbrQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblNbrQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrQuestions.ForeColor = System.Drawing.Color.White;
            this.lblNbrQuestions.Location = new System.Drawing.Point(756, 425);
            this.lblNbrQuestions.Name = "lblNbrQuestions";
            this.lblNbrQuestions.Size = new System.Drawing.Size(32, 16);
            this.lblNbrQuestions.TabIndex = 5;
            this.lblNbrQuestions.Text = "1/10";
            // 
            // reponse2
            // 
            this.reponse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse2.Location = new System.Drawing.Point(245, 270);
            this.reponse2.Name = "reponse2";
            this.reponse2.Size = new System.Drawing.Size(330, 65);
            this.reponse2.TabIndex = 10;
            this.reponse2.UseVisualStyleBackColor = true;
            this.reponse2.Click += new System.EventHandler(this.reponse2_Click);
            // 
            // reponse3
            // 
            this.reponse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reponse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse3.Location = new System.Drawing.Point(412, 190);
            this.reponse3.Name = "reponse3";
            this.reponse3.Size = new System.Drawing.Size(334, 65);
            this.reponse3.TabIndex = 11;
            this.reponse3.UseVisualStyleBackColor = true;
            this.reponse3.Click += new System.EventHandler(this.reponse3_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetMadeInValDeLoire.Properties.Resources.question;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reponse3);
            this.Controls.Add(this.reponse2);
            this.Controls.Add(this.difficulte);
            this.Controls.Add(this.lblNbrQuestions);
            this.Controls.Add(this.reponse1);
            this.Controls.Add(this.lblQuestion);
            this.DoubleBuffered = true;
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button reponse1;
        private System.Windows.Forms.Label difficulte;
        private System.Windows.Forms.Label lblNbrQuestions;
        private System.Windows.Forms.Button reponse2;
        private System.Windows.Forms.Button reponse3;
    }
}