using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMadeInValDeLoire
{
    public partial class Question : Form
    {

        private int questionsNbr;
        private String niveau;
        private String username;
        private String password;
        
        public Question(String niveau)
        {
            InitializeComponent();
            difficulte.Text = "Difficulté : " + niveau;
            this.niveau = niveau;
            questionsNbr = 1;
            lblNbrQuestions.Text = questionsNbr + "/10";
        }

        public Question(String niveau, int questionNbr)
        {
            InitializeComponent();
            difficulte.Text = "Difficulté : " + niveau;
            this.niveau = niveau;
            questionsNbr = questionNbr;
            lblNbrQuestions.Text = questionsNbr + "/10";
        }

        public Question(String niveau, String username, String password)
        {
            InitializeComponent();
            difficulte.Text = "Difficulté : " + niveau;
            this.niveau = niveau;
            questionsNbr = 1;
            lblNbrQuestions.Text = questionsNbr + "/10";
            this.username = username;
            this.password = password; 
        }

        public Question(String niveau, int questionNbr, String username, String password)
        {
            InitializeComponent();
            difficulte.Text = "Difficulté : " + niveau;
            this.niveau = niveau;
            questionsNbr = questionNbr;
            lblNbrQuestions.Text = questionsNbr + "/10";
            this.username = username;
            this.password = password;
        }

        private void btnRepondre_Click(object sender, EventArgs e)
        {
            if (questionsNbr < 10)
            {
                this.Hide();
                if (username == null && password == null)
                {
                    Question quest = new Question(niveau, questionsNbr + 1);
                    quest.Closed += (s, args) => this.Close();
                    quest.Show();
                }
                else
                {
                    Question quest = new Question(niveau, questionsNbr + 1, username, password);
                    quest.Closed += (s, args) => this.Close();
                    quest.Show();
                }
            }
            else if (questionsNbr == 10)
            {
                this.Hide();
                if (username == null && password == null)
                {
                    Resultats result = new Resultats();
                    result.Closed += (s, args) => this.Close();
                    result.Show();
                }
                else
                {
                    Resultats result = new Resultats(username, password);
                    result.Closed += (s, args) => this.Close();
                    result.Show();
                }
            }
        }

        private void reponse1_Click(object sender, EventArgs e)
        {
            answerClick(reponse1);
        }

        private void reponse2_Click(object sender, EventArgs e)
        {
            answerClick(reponse2);
        }

        private void reponse3_Click(object sender, EventArgs e)
        {
            answerClick(reponse3);
        }

        private void reponse4_Click(object sender, EventArgs e)
        {
            answerClick(reponse4);
        }

        private void answerClick(Button btn)
        {
            if(btn.BackColor == SystemColors.Control)
            {
                btn.BackColor = SystemColors.ControlDark;
            }
            else if (btn.BackColor == SystemColors.ControlDark)
            {
                btn.BackColor = SystemColors.Control;
            }
        }
    }
}
