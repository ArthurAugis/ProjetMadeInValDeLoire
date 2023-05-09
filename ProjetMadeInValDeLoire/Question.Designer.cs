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
            this.reponse2 = new System.Windows.Forms.Button();
            this.reponse4 = new System.Windows.Forms.Button();
            this.reponse3 = new System.Windows.Forms.Button();
            this.lblNbrQuestions = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnRepondre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(298, 115);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(199, 29);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "C\'est quoi la vie ?";
            // 
            // reponse1
            // 
            this.reponse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse1.Location = new System.Drawing.Point(276, 147);
            this.reponse1.Name = "reponse1";
            this.reponse1.Size = new System.Drawing.Size(119, 29);
            this.reponse1.TabIndex = 1;
            this.reponse1.Text = "Feur";
            this.reponse1.UseVisualStyleBackColor = true;
            // 
            // reponse2
            // 
            this.reponse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse2.Location = new System.Drawing.Point(401, 147);
            this.reponse2.Name = "reponse2";
            this.reponse2.Size = new System.Drawing.Size(119, 29);
            this.reponse2.TabIndex = 2;
            this.reponse2.Text = "C\'est ça";
            this.reponse2.UseVisualStyleBackColor = true;
            // 
            // reponse4
            // 
            this.reponse4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse4.Location = new System.Drawing.Point(401, 182);
            this.reponse4.Name = "reponse4";
            this.reponse4.Size = new System.Drawing.Size(119, 29);
            this.reponse4.TabIndex = 4;
            this.reponse4.Text = "le cul";
            this.reponse4.UseVisualStyleBackColor = true;
            // 
            // reponse3
            // 
            this.reponse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reponse3.Location = new System.Drawing.Point(276, 182);
            this.reponse3.Name = "reponse3";
            this.reponse3.Size = new System.Drawing.Size(119, 29);
            this.reponse3.TabIndex = 3;
            this.reponse3.Text = "42";
            this.reponse3.UseVisualStyleBackColor = true;
            // 
            // lblNbrQuestions
            // 
            this.lblNbrQuestions.AutoSize = true;
            this.lblNbrQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrQuestions.Location = new System.Drawing.Point(377, 399);
            this.lblNbrQuestions.Name = "lblNbrQuestions";
            this.lblNbrQuestions.Size = new System.Drawing.Size(32, 16);
            this.lblNbrQuestions.TabIndex = 5;
            this.lblNbrQuestions.Text = "1/10";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(415, 398);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(17, 19);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(354, 398);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(17, 19);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnRepondre
            // 
            this.btnRepondre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepondre.Location = new System.Drawing.Point(276, 242);
            this.btnRepondre.Name = "btnRepondre";
            this.btnRepondre.Size = new System.Drawing.Size(244, 51);
            this.btnRepondre.TabIndex = 8;
            this.btnRepondre.Text = "C\'est mon ultime bafouille Jean-Pierre";
            this.btnRepondre.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRepondre);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblNbrQuestions);
            this.Controls.Add(this.reponse4);
            this.Controls.Add(this.reponse3);
            this.Controls.Add(this.reponse2);
            this.Controls.Add(this.reponse1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Question";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button reponse1;
        private System.Windows.Forms.Button reponse2;
        private System.Windows.Forms.Button reponse4;
        private System.Windows.Forms.Button reponse3;
        private System.Windows.Forms.Label lblNbrQuestions;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRepondre;
    }
}